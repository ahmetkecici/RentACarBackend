using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CarDetailListDto
    {

        public int Id { get; set; }
        public string BrandName { get; set; }
        public string CarModelName { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
        public string CarType { get; set; }
        public string TransmissionType { get; set; }
        public int ModelYear { get; set; }
        public string ChassisNumber { get; set; }
        public string Plate { get; set; }
        public string MainImage { get; set; }
        public int DailyPrice { get; set; }
        public List<string> Images { get; set; }

    }
}
