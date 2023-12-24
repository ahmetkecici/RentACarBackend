using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Dal.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageService:ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageService(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public List<CarImage> GetImagesByCar(int id)
        {
            var data = _carImageDal.GetAll(x => x.CarId == id);
            return data;
        }
    }
}
