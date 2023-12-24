using Dal.Abstract;
using Entities.Concrete;

namespace Dal.Concrete.EntityFramework;

public class EfTransmissionTypeDal : EfGenericRepository<TrasmissionType, RentACarContext>, ITransmissionTypeDal
{


}