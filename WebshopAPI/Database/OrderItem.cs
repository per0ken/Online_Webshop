namespace WebshopAPI.Database
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }  // Melyik rendeléshez tartozik
        public int ProductId { get; set; }  // Melyik terméket vásárolták meg
        public int Quantity { get; set; }  // Hány darabot rendeltek belőle
        public decimal Price { get; set; }  // Az akkori ár, amikor megrendelték

        public Order Order { get; set; }  // Kapcsolat a rendeléshez
        public Product Product { get; set; }  // Kapcsolat a termékhez
    }

}
