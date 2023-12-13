using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Store myStore = new Store();

            
            myStore.AddProduct(new Product("Laptop", 1200, "High-performance laptop", "Electronics", 4));
            myStore.AddProduct(new Product("Smartphone", 800, "Latest smartphone model", "Electronics", 5));
            myStore.AddProduct(new Product("Book", 20, "Bestselling novel", "Books", 4));

           
            myStore.AddUser(new User("john_doe", "password123"));
            myStore.AddUser(new User("jane_smith", "securepass"));

            
            Console.WriteLine("Search for products:");
            myStore.DisplayProductsMatchingCriteria(0, 1000, "Electronics", 4);

            User currentUser = myStore.Users[0];
            List<Product> selectedProducts = myStore.Products.Where(p => p.Category == "Electronics").ToList();
            myStore.PlaceOrder(currentUser, selectedProducts, 2);

            Console.ReadLine();
        }
    }
}
