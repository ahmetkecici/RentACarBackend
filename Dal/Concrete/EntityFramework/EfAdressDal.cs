using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfAdressDal : EfGenericRepository<Adress, RentACarContext>, IAdressDal
{


}