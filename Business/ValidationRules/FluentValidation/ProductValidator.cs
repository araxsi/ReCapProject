using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Cars>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Description).MaximumLength(2);
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
            //Özel hata Mesajı verilirken kullanılan yöntemdir.
            RuleFor(p => p.Description).Must(StartWithA).WithMessage("Ürünler A ile başlamalıdır.");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
