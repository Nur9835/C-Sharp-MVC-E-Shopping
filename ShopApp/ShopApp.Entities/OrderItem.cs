using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Cart Cart { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
     public decimal Price { get; set; } //sipariş esnasında üründe fiyat değişimi sipraiş tutarını etkilememesi
  
        
        }
}
