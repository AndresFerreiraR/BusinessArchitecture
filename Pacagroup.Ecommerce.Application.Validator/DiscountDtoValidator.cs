
namespace Pacagroup.Ecommerce.Application.Validator
{
    using FluentValidation;
    using Pacagroup.Ecommerce.Application.DTO;

    /// <summary>
    /// 
    /// </summary>
    public class DiscountDtoValidator : AbstractValidator<DiscountDto>
    {
        public DiscountDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Description).NotNull().NotEmpty();
            RuleFor(x => x.Percent).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
