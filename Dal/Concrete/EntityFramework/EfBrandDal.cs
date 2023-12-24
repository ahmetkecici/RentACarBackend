using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfBrandDal : EfGenericRepository<Brand, RentACarContext>, IBrandDal
{


}
public class EfCarTypeDal : EfGenericRepository<CarType, RentACarContext>, ICarTypeDal
{


}