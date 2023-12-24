using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Mapping.Automapper
{
    internal class CarMappingProfile:Profile
    {
        public CarMappingProfile()
        {
            CreateMap<Car, CarAddDto>().ReverseMap();
        }
    }
}
