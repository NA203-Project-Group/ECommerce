using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(x => x.DistrictName).NotEmpty();
            RuleFor(x => x.DistrictName).MaximumLength(50);
            RuleFor(x => x.DistrictName).MinimumLength(3);

        }
    }
}
