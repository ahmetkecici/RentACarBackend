using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAccountService
    {
        IResult Register(RegisterDto registerDto);
        IDataResult<User>  Login(LoginDto loginDto);
        void EditProfile(UserUpdateDto userUpdate);
    }
}
