using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CarModelId { get; set; }
        public int FuelTypeId { get; set; }
        public int ColorId { get; set; }
        public int CarTypeId { get; set; }
        public int TransmissionTypeId { get; set; }
        public int ModelYear { get; set; }
        public string ChassisNumber { get; set; }
        public string Plate { get; set; }
        public int DailyPrice { get; set; }
    }
}
