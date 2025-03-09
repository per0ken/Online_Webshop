using WebshopAPI.Enums;

namespace WebshopAPI.Database
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }

}
