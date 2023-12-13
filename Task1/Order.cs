using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Products.Sum(p => p.Price * Quantity);
        public OrderStatus Status { get; set; }

        public Order(List<Product> products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            Status = OrderStatus.Pending;
        }
    }
    enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
}
