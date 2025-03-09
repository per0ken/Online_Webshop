namespace WebshopAPI.Database
{
    public class CartItem
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
