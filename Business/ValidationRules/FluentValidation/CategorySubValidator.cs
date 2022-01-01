using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategorySubValidator : AbstractValidator<CategorySub>
    {
        public CategorySubValidator()
        {
            RuleFor(x => x.CategoryID).NotEmpty();
            RuleFor(x => x.CategorySubName).MaximumLength(50);
        }
    }
}
