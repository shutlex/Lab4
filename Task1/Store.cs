using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Store
    {
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }

        public Store()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void DisplayProductsMatchingCriteria(decimal minPrice, decimal maxPrice, string targetCategory, int minRating)
        {
            var matchingProducts = Products.Where(p => p.MatchesCriteria(minPrice, maxPrice, targetCategory, minRating)).ToList();

            Console.WriteLine("Matching Products:");
            foreach (var product in matchingProducts)
            {
                Console.WriteLine($"{product.Name} - {product.Price:C} - Category: {product.Category} - Rating: {product.Rating}");
            }
        }

        public void PlaceOrder(User user, List<Product> products, int quantity)
        {
            var order = new Order(products, quantity);
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
            Console.WriteLine("Order placed successfully.");
        }
    }
}
