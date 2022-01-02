using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductDetailValidator :AbstractValidator<ProductDetail>
    {
        public ProductDetailValidator()
        {
            RuleFor(x => x.StockAmount).NotNull();
            RuleFor(x => x.ProductDescription).NotEmpty();
            RuleFor(x => x.ProductDescription).MaximumLength(250);
            RuleFor(x => x.ProductID).NotNull();

        }
    }
}
