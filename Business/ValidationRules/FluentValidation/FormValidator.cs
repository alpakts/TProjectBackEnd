using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class FormValidator : AbstractValidator<TechnicForm>
    {
        public FormValidator()
        {
            RuleFor(t => t.DeviceName).NotEmpty();
            RuleFor(t => t.DeviceName).MinimumLength(5);
        }


    }
}
