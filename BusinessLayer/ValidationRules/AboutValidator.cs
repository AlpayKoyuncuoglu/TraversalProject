using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Fill the Description");
            RuleFor(x => x.ImageFirst).NotEmpty().WithMessage("Pick an Image File");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Write at least 50 charachters");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Write at most 1500 charachters");
        }
    }
}
