using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MaximumLength(50);
        RuleFor(p => p.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(p => p.Password).NotEmpty().Matches("^(?=.*\\d).*$").WithMessage("Must contain a numeric value");

    }
}
