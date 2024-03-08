using BusinessLogic.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IValidator<CreateCustomerRequest> _validator;


        public OrderController(IValidator<CreateCustomerRequest> validator)
        {
            _validator = validator;
        }

        [HttpPost]
        public async Task<ActionResult> PostCustomer([FromBody] CreateCustomerRequest createCustomerRequest)
        {
            ValidationResult result = await _validator.ValidateAsync(createCustomerRequest);

            if (!result.IsValid)
            {
                return BadRequest(result);
            }

            //rest of the logic
            return Created();
        }
    }
}
