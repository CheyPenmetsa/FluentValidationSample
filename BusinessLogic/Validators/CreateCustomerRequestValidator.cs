using BusinessLogic.Models;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(cus => cus.FirstName).NotEmpty().MaximumLength(100);

            RuleFor(cus => cus.LastName).NotEmpty().MaximumLength(100);

            RuleFor(cus => cus.Email).NotEmpty().EmailAddress().WithMessage("Email not in expected format");

            RuleFor(cus => cus.Age).GreaterThan(20);

            RuleFor(cus => cus.PhysicalAddress).NotNull().SetValidator(new AddressRequestValidator());

            RuleFor(cus => cus.MailingAddress).NotNull().SetValidator(new AddressRequestValidator());

            RuleFor(cus => cus.Order).NotNull().SetValidator(new OrderRequestValidator());
        }
    }
}
