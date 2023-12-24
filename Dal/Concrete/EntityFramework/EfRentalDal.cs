using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfRentalDal : EfGenericRepository<Rental, RentACarContext>, IRentalDal
{


}