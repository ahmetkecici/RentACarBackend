using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfCityDal : EfGenericRepository<City, RentACarContext>, ICityDal
{


}