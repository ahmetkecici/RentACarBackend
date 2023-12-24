using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        User GetByUserName(string userName);
        UserUpdateDto GetUserToUpdate(int id);
        void Update(User user);
    }
}
