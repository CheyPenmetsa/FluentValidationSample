namespace BusinessLogic.Models
{
    public class OrderRequest
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string PromoCode { get; set; }
    }
}
