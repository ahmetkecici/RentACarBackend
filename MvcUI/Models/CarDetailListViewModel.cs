using Business.Concrete;
using Entities.Dtos;

namespace MvcUI.Models
{
    public class CarDetailListViewModel
    {
        public List<CarDetailListDto> CarDetailListDtos { get; set; }
        public CarFilterModel CarFilterModel { get; set; }
    }
}
