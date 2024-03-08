using BusinessLogic.Models;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class OrderRequestValidator : AbstractValidator<OrderRequest>
    {
        public OrderRequestValidator()
        {
            RuleFor(or=>or.ProductName).NotEmpty().MaximumLength(255).WithMessage("Product Name Required for placing order");

            RuleFor(or => or.Quantity).GreaterThan(0).LessThan(50);

            RuleFor(or => or.PromoCode).NotEmpty().MaximumLength(10);
        }
    }
}
