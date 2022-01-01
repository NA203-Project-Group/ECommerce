using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x => x.CityName).NotEmpty();
            RuleFor(x => x.CityName).MaximumLength(50);
            RuleFor(x => x.CityName).MinimumLength(3);
        }
  
    }
}
