using WebshopAPI.Enums;

namespace WebshopAPI.Database
{
    public class Order
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required List<OrderItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }

}
