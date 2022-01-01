using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BasketDetailValidator : AbstractValidator<BasketDetail>
    {
        public BasketDetailValidator()
        {
            RuleFor(x => x.BasketID).NotNull();
            RuleFor(x => x.ProductID).NotNull();
            RuleFor(x => x.CustomerID).NotNull();
            RuleFor(x => x.InstalmentDate).NotNull();

        }
    }
}
