using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Extensions;
using Business.Validation.FluentValidation;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AccounService:IAccountService
    {
        private IMapper _mapper;
        IUserService _userService;

        public AccounService(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        public IResult Register(RegisterDto registerDto)
        {
            RegisterDtoValidator validator = new RegisterDtoValidator();
           var validationResult= validator.Validate(registerDto);
           if (!validationResult.IsValid)
           {
               return new Result(false,validationResult.ConvertToCustomValidationError());
           }
            var user = _mapper.Map<User>(registerDto);
            HMACSHA512 hmacsha512=new HMACSHA512();
            user.PasswordHash = hmacsha512.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
            user.PasswordSalt = hmacsha512.Key;
            _userService.Add(user);
            return new Result(true);
        }

        public IDataResult<User> Login(LoginDto loginDto)
        {
            var user = _userService.GetByUserName(loginDto.UserName);
            if (user == null)
            {
                return new DataResult<User>(false,"Kullanıcı bulunamadı");
            }
            var hmac=new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return new DataResult<User>(false, "Parolası Yanlış");

            }

            return new DataResult<User>(true, "Giriş Başarılı", user);

        }

        public void EditProfile(UserUpdateDto userUpdate)
        {
            var user = _mapper.Map<User>(userUpdate);
            _userService.Update(user);
        }
    }
}
