using BusinessLogic.Models;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class AddressRequestValidator : AbstractValidator<AddressRequest>
    {
        public AddressRequestValidator()
        {
            RuleFor(add => add.Line1).NotEmpty().MaximumLength(255);

            RuleFor(add => add.Line1).MaximumLength(255);

            RuleFor(add => add.City).NotEmpty().MaximumLength(50);

            RuleFor(add => add.State).NotEmpty().MaximumLength(50);

            RuleFor(add => add.PostalCode).ZipCode();
        }
    }
}
