using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfDistrictDal : EfGenericRepository<District, RentACarContext>, IDistrictDal
{


}