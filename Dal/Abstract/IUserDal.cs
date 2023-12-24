using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Dal.Abstract
{
    public interface IUserDal:IGenericRepositoryBase<User>
    {
        
    }
}
