using FluentValidation;

namespace OK.Tech.Domain.Entities.Validations
{
  public class PriceListValidation : AbstractValidator<PriceList>
  {
    public PriceListValidation()
    {
      RuleFor(p => p.Name)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(3, 200).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");
    }
  }
}