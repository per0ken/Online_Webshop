﻿namespace WebshopAPI.Database
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; } 
        public int ProductId { get; set; } 
        public int Quantity { get; set; } 
        public decimal Price { get; set; }

        public required Order Order { get; set; }  // which order
        public required Product Product { get; set; }  // which product
    }

}
