using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.ProductImage).NotEmpty();
            RuleFor(x => x.CategoryId).NotNull();
            RuleFor(x => x.UnitPrice).NotNull();
            RuleFor(x => x.Favorite).NotEmpty();


            RuleFor(x => x.ProductName).MaximumLength(100);
            RuleFor(x => x.UnitPrice).GreaterThan(0);
        }
    }
}
