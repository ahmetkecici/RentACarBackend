using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfCurrencyDal : EfGenericRepository<Currency, RentACarContext>, ICurrencyDal
{


}