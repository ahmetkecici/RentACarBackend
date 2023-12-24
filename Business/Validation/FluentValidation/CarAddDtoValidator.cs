using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;
using FluentValidation;

namespace Business.Validation.FluentValidation
{
    public class CarAddDtoValidator:AbstractValidator<CarAddDto>
    {
        public CarAddDtoValidator()
        {
            RuleFor(x => x.BrandId).NotEmpty().GreaterThan(0).WithMessage("Araba Markası Boş Olamaz");
           RuleFor(x => x.CarImages.Count).GreaterThan(0);
           RuleFor(x => x.CarImages.Count).LessThan(5);

        }
    }
}
