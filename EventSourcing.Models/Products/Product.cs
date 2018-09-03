using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Models.Products
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }
    }
}
