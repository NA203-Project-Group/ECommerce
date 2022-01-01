using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CommentValidator :AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Star).NotNull();
            RuleFor(x => x.Star).LessThanOrEqualTo(5);
            RuleFor(x => x.CommentDescription).NotEmpty();
            RuleFor(x => x.CommentDescription).MaximumLength(250);
        }
    }
}
