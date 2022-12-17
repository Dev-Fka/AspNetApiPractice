using AspNetApiPractice.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Validator
{
    public class UserValidator :AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(u=> u.FullName).NotEmpty().WithMessage("Boş bırakılamaz.");
            RuleFor(u => u.PasswordHash).NotEmpty().WithMessage("Boş bırakılamaz.");
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Boş bırakılamaz.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Boş bırakılamaz.");
        }

    }
}
