using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Adress
    {
        public int Id { get; set; }

        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string AdressText { get; set; }
    }
}
