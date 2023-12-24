using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;

namespace Dal.Abstract
{
    public interface ICarDal: IGenericRepositoryBase<Car>
    {
        CarDetailListDto GetDetails(Expression<Func<Car,bool>> filter);
        List<CarDetailListDto> GetAllCarsWithDetails(Expression<Func<Car,bool>> filter=null);

    }
}
