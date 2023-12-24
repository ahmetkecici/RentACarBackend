using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarDetailListDto> GetCarDetailList();
        CarDetailListDto GetCarDetail(int id);
        Car Add(CarAddDto carAddDto);
    }
}
