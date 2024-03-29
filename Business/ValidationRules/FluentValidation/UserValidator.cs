﻿using Core.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).Must(Contain).WithMessage("Emailde @ sembolü olmalıdır");
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(5);
            RuleFor(u => u.Password).NotEmpty();
        }
        public bool Contain(string args)
        {
            if (args.Contains("@"))
            {
                return true;
            }
            return false;
        }
    }
}
