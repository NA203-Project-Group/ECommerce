using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BasketValidator :AbstractValidator<Basket>
    {
        public BasketValidator()
        {
            RuleFor(x => x.ProductID).NotNull();
            RuleFor(x => x.CustomerID).NotNull();
            RuleFor(x => x.Quantity).NotNull();
            RuleFor(x => x.RequiredDate).NotEmpty();
            RuleFor(x => x.MinPrice).NotNull();
            RuleFor(x => x.MinPrice).GreaterThan(0);
        }
    }
}
