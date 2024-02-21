using FluentValidation;

namespace Pacagroup.Ecommerce.Application.UseCases.Users.CreateUsersTokenCommand
{
    public class CreateUserTokenValidator : AbstractValidator<CreateUsersTokenCommand>
    {
        public CreateUserTokenValidator()
        {
            RuleFor(u => u.UserName).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty();
        }
    }
}