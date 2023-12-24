using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfColorDal : EfGenericRepository<Color, RentACarContext>, IColorDal
{


}