using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty();
            RuleFor(x => x.CustomerSurname).NotEmpty();
            RuleFor(x => x.CustomerMail).NotEmpty();
            RuleFor(x => x.CustomerPassword).NotEmpty();
            RuleFor(x => x.CustomerGsm).NotEmpty();
            RuleFor(x => x.CartID).NotNull();
            RuleFor(x => x.CommnetID).NotNull();
            RuleFor(x => x.AddressID).NotNull();

            RuleFor(x => x.CustomerName).MaximumLength(50);
            RuleFor(x => x.CustomerSurname).MaximumLength(50);
            RuleFor(x => x.CustomerMail).MaximumLength(50);
            RuleFor(x => x.CustomerMail).EmailAddress();
            RuleFor(x => x.CustomerPassword).MaximumLength(50);
            RuleFor(x => x.CustomerGsm).MaximumLength(11);
        }
    }
}
