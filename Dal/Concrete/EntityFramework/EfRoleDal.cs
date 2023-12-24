using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfRoleDal : EfGenericRepository<Role, RentACarContext>, IRoleDal
{


}