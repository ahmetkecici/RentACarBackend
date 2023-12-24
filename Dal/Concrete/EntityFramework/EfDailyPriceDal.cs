using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfDailyPriceDal : EfGenericRepository<DailyPrice, RentACarContext>, IDailyPriceDal
{


}