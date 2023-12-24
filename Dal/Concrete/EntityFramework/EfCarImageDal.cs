using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfCarImageDal : EfGenericRepository<CarImage, RentACarContext>, ICarImageDal
{


}