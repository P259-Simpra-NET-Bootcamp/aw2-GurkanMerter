using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class StaffValidator:AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("İsim boş geçilemez.");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soy isim boş geçilemez.");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email boş geçilemez.");
            RuleFor(s => s.Email).EmailAddress().WithMessage("Email formatına uygun şekilde giriniz.");
            RuleFor(s => s.Phone).NotEmpty().WithMessage("Numara boş geçilemez.");
            RuleFor(s => s.DateOfBirth).NotEmpty().WithMessage("Doğum tarihi boş geçilemez.");
            RuleFor(s => s.AddressLine1).NotEmpty().WithMessage("Adres boş geçilemez.");
            RuleFor(s => s.City).NotEmpty().WithMessage("Şehir boş geçilemez.");
            RuleFor(s => s.Country).NotEmpty().WithMessage("Ülke boş geçilemez.");
            RuleFor(s => s.Province).NotEmpty().WithMessage("İl boş geçilemez.");
        }
    }
}
