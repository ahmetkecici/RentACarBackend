using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfCarModelDal : EfGenericRepository<CarModel, RentACarContext>, ICarModelDal
{


}