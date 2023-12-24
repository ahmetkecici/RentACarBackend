using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Dal.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UserService:IUserService
    {
        private IUserDal _userDal;
        private IMapper _mapper;
        public UserService(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

     


        public void Add(User user)
        {
          var id=   _userDal.Add(user);

        }


        public User GetByUserName(string userName)
        {
            return _userDal.Get(x => x.UserName == userName);
        }

        public UserUpdateDto GetUserToUpdate(int id)
        {
            var data = _userDal.Get(x => x.Id == id);
            var userToUpdate = _mapper.Map<UserUpdateDto>(data);
            return userToUpdate;
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
