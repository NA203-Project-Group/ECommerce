using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.AddressID).NotNull();
            RuleFor(x => x.CityID).NotNull();
            RuleFor(x => x.DistrictID).NotNull();
            RuleFor(x => x.BuildingNumber).NotEmpty();
            RuleFor(x => x.BuildingNumber).MaximumLength(10);
        }
    }
}
