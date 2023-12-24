using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dal.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Dal.Concrete.EntityFramework
{
    public class EfCarDal : EfGenericRepository<Car, RentACarContext>, ICarDal
    {

        public CarDetailListDto GetDetails(Expression<Func<Car, bool>> filter)
        {
            using (var context = new RentACarContext())
            {
                var result = from car in context.Cars.Where(filter)
                    join color in context.Colors
                        on car.ColorId equals color.Id
                    join brand in context.Brands
                        on car.BrandId equals brand.Id
                    join model in context.CarModels
                        on car.BrandId equals model.Id

                    join carType in context.CarTypes
                        on car.CarTypeId equals carType.Id
                    join transmissionType in context.TransmissionTypes
                        on car.TransmissionTypeId equals transmissionType.Id
                    join fuelType in context.FuelTypes
                        on car.FuelTypeId equals fuelType.Id

                    select new CarDetailListDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ModelYear = car.ModelYear,
                        ChassisNumber = car.ChassisNumber,
                        CarModelName = model.Name,
                        Plate = car.Plate,
                        Color = color.Name,
                        MainImage = carType.Name,
                        TransmissionType = transmissionType.Name,
                        DailyPrice = car.DailyPrice

                    };
                return result.SingleOrDefault();

            }
        }

        public List<CarDetailListDto> GetAllCarsWithDetails(Expression<Func<Car,bool>> filter=null )
        {
            using (var context = new RentACarContext())
            {          
                var result = from car in filter==null? context.Cars:context.Cars.Where(filter)
                    join color in context.Colors
                        on car.ColorId equals color.Id
                    join brand in context.Brands
                        on car.BrandId equals brand.Id
                    join model in context.CarModels
                        on car.BrandId equals model.Id

                    join carType in context.CarTypes
                        on car.CarTypeId equals carType.Id
                    join transmissionType in context.TransmissionTypes
                        on car.TransmissionTypeId equals transmissionType.Id
                    join fuelType in context.FuelTypes
                        on car.FuelTypeId equals fuelType.Id
                        
                    select new CarDetailListDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ModelYear = car.ModelYear,
                        ChassisNumber = car.ChassisNumber,
                        CarModelName = model.Name,
                        Plate = car.Plate,
                        Color = color.Name,
                        MainImage = context.CarImages.Where(x=>x.CarId==car.Id).SingleOrDefault().Path,
                        DailyPrice = car.DailyPrice,
                        TransmissionType = transmissionType.Name,


                    };
                
                return result.ToList();
            }

        
        }
    }
}
