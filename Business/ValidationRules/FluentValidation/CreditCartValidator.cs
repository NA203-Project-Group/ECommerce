using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCartValidator :AbstractValidator<CreditCart>
    {
        public CreditCartValidator()
        {
            RuleFor(x => x.CartID).NotNull();
            RuleFor(x => x.CartNumber).NotEmpty();
            RuleFor(x => x.CartNameSurname).NotEmpty();
            RuleFor(x => x.CartMouth).NotEmpty();
            RuleFor(x => x.CartYear).NotEmpty();
            RuleFor(x => x.CartCvs).NotEmpty();

            RuleFor(x => x.CartNumber).MinimumLength(16);
            RuleFor(x => x.CartNumber).MaximumLength(16);

            RuleFor(x => x.CartNameSurname).MaximumLength(50);

            RuleFor(x => x.CartMouth).MinimumLength(2);
            RuleFor(x => x.CartMouth).MaximumLength(2);

            RuleFor(x => x.CartYear).MinimumLength(2);
            RuleFor(x => x.CartYear).MaximumLength(2);

            RuleFor(x => x.CartCvs).MinimumLength(3);
            RuleFor(x => x.CartCvs).MaximumLength(3);

        }
    }
}
