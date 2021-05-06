using FluentValidation;

namespace OK.Tech.Domain.Entities.Validations
{
  public class ProductValidation : AbstractValidator<Product>
  {
    public ProductValidation()
    {
      RuleFor(p => p.Name)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(3, 200).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");


      RuleFor(p => p.Description)
      .NotEmpty().WithMessage("The {PropertyName} must br supplied")
      .Length(3, 1000).WithMessage("The field {PropertyName} length must br between {MinLength} and {MaxLength}");
    }
  }
}
