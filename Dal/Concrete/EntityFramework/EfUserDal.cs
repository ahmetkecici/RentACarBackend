using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework
{
    public  class EfUserDal:EfGenericRepository<User,RentACarContext>,IUserDal
    {
     
       
    }
}
