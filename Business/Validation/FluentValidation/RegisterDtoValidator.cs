using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;
using FluentValidation;

namespace Business.Validation.FluentValidation
{
    public class RegisterDtoValidator:AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.UserName).MinimumLength(5).MaximumLength(8)
                .WithMessage("Kullanıcı Adı 5 Karakter Ve 8 Karakter Arası olmalıdır");

            RuleFor(x => x.IdentityNumber).NotEmpty().WithMessage("Tc Kimlik No boş olamaz");
            RuleFor(x => x.IdentityNumber).Length(11)
                .WithMessage("Tc Kimlik No 11 haneli olmalıdır");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Adı boş olamaz");
            RuleFor(x => x.FirstName).MinimumLength(5)
                .WithMessage("Adı en az 5 Karakter  Karakter içermelidir");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyadı kısmı boş olamaz");
            RuleFor(x => x.UserName).MinimumLength(5)
                .WithMessage("Soyadı en az 5 Karakter  Karakter içermelidir");
            RuleFor(x => x.UserName).MinimumLength(5)
                .WithMessage("Soyadı en az 5 Karakter  Karakter içermelidir");


        }
    }
}

//public string IdentityNumber { get; set; }
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public string Gender { get; set; }
//public DateTime? BirthDate { get; set; }
//public string Mail { get; set; }
//public string Password { get; set; }
//public string PasswordConfirm { get; set; }