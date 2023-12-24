using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Dal.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CarService:ICarService
    {
        private ICarDal _carDal;
        private IMapper _mapper;
        public CarService(ICarDal carDal, IMapper mapper)
        {
            _carDal = carDal;
            _mapper = mapper;
        }

        public List<CarDetailListDto> GetCarDetailList()
        {

            var data = _carDal.GetAllCarsWithDetails();
            return data;
        }

        public CarDetailListDto GetCarDetail(int id)
        {
           return _carDal.GetDetails(x=>x.Id==id);
        }

        public Car Add(CarAddDto carAddDto)
        {
            Car car = _mapper.Map<Car>(carAddDto);
            _carDal.Add(car);
            return car;
        }

        public  List<CarDetailListDto> GetFilteredCar(CarFilterModel filterModel)
        {
          
         return   _carDal.GetAllCarsWithDetails(x=>filterModel.BrandIds.Contains(x.BrandId));
        }
    }

    public class CarFilterModel
    {
        public List<int> BrandIds { get; set; }
        public List<int> ColorIds { get; set; }
    }
}
