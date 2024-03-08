using FluentValidation;

namespace BusinessLogic.Validators
{
    public static class FluentValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> ZipCode<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            //"^[0-9]{5}(?:-[0-9]{4})?$"
            return ruleBuilder
                       .NotEmpty()
                       .Matches(@"\d{5}$");
        }
    }
}
