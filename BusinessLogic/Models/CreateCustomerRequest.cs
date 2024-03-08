namespace BusinessLogic.Models
{
    public class CreateCustomerRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public AddressRequest MailingAddress { get; set; }

        public AddressRequest PhysicalAddress { get; set; }

        public OrderRequest Order { get; set; }
    }
}
