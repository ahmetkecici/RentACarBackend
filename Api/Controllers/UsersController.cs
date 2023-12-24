using Business.Abstract;
using Business.Concrete;
using Dal.Concrete.EntityFramework;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private RentACarContext _context;
        private IAccountService _accountService;
        public UsersController(RentACarContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
       
            return Ok( await _context.Users.ToListAsync());
        }
        [HttpPost]
        public IActionResult Register(RegisterDto registerDto)

        {
           _accountService.Register(registerDto);
           return Ok(registerDto);
        }
    }
}
