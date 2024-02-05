using FluentValidation;
using Pacagroup.Ecommerce.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacagroup.Ecommerce.Application.Validator
{
    public class UsersDtoValidator : AbstractValidator<UsersDto>
    {
        public UsersDtoValidator()
        {
            RuleFor(u => u.UserName).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty();
        }
    }
}
