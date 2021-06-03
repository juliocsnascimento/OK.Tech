using FluentValidation;

namespace OK.Tech.Domain.Entities.Validations
{
  public class CustomerValidation : AbstractValidator<Customer>
  {
    public CustomerValidation()
    {
      RuleFor(p => p.Name)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(3, 200).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");

      RuleFor(p => p.Birthdate)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied");

      RuleFor(p => p.Phone)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(3, 15).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");

      RuleFor(p => p.Email)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(5, 200).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");
    }
  }
}
