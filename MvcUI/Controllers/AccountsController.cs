using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace MvcUI.Controllers
{
    public class AccountsController : Controller
    {
        private IAccountService _accountService;
        private IUserService _userService;
        public AccountsController(IAccountService accountService, IUserService userService)
        {
            _accountService = accountService;
            _userService = userService;
        }

        public IActionResult Register()
        {
            return View(new RegisterDto());
        }

        [HttpPost]
        public IActionResult Register(RegisterDto registerDto)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            var result =_accountService.Register(registerDto);
            if (!result.Success)
            {
                foreach (var error in result.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName,error.Error);
                }
                return View(registerDto);

            }
            return RedirectToAction("Index","Home");
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(new LoginDto());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
           

            if (ModelState.IsValid)
            {
                // Use Input.Email and Input.Password to authenticate the user
                // with your custom authentication logic.
                //
                // For demonstration purposes, the sample validates the user
                // on the email address maria.rodriguez@contoso.com with 
                // any password that passes model validation.

                var result =  _accountService.Login(loginDto);

                if (!result.Success)
                {
                    ModelState.AddModelError(string.Empty, result.Message);
                    return View(loginDto);
                }


                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, result.Data.FirstName),
          //    a  new Claim("FullName", result.Data.FirstName),
            new Claim(ClaimTypes.Role, "Member"),
            new Claim("Id",result.Data.Id.ToString()),
            new Claim("UserName",result.Data.UserName)
        };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);


                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            // Something failed. Redisplay the form.
            return View(loginDto);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            int id =Convert.ToInt32( HttpContext.User.Claims.Where(x=>x.Type=="Id").SingleOrDefault().Value);
            var userToUpdateDto=_userService.GetUserToUpdate(id);

            return View(userToUpdateDto);
        }
        [HttpPost]
        public IActionResult EditProfile(UserUpdateDto userUpdateDto)
        {


            return RedirectToAction("Index", "Home");
        }
    }
}
