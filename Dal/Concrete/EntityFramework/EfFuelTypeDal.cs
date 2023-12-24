using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfFuelTypeDal : EfGenericRepository<FuelType, RentACarContext>, IFuelTypeDal
{


}