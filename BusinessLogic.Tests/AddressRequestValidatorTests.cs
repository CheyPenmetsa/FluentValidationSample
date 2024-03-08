using BusinessLogic.Validators;
using FluentValidation.TestHelper;

namespace BusinessLogic.Tests
{
    [TestFixture]
    public class AddressRequestValidatorTests
    {
        private readonly AddressRequestValidator _validator = new AddressRequestValidator();

        [Test]
        public void GivenValidLine1_Should_Not_Have_Error()
        {
            var result = _validator.TestValidate(new Models.AddressRequest() 
            {
                Line1 = "123 Main Street"
            });

            result.ShouldNotHaveValidationErrorFor(add => add.Line1);
        }

        [Test]
        public void GivenInvalidZipCode_Should_Have_Error()
        {
            var result = _validator.TestValidate(new Models.AddressRequest()
            {
                PostalCode = "ABCDE"
            });

            result.ShouldHaveValidationErrorFor(add => add.PostalCode);
        }

        [Test]
        public void GivenvalidZipCode_Should_Not_Have_Error()
        {
            var result = _validator.TestValidate(new Models.AddressRequest()
            {
                PostalCode = "78613"
            });

            result.ShouldNotHaveValidationErrorFor(add => add.PostalCode);
        }
    }
}
