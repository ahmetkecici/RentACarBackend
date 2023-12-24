using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfUserRoleDal : EfGenericRepository<UserRole, RentACarContext>, IUserRoleDal
{


}