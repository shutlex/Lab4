using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Product : ISearchable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }

        public Product(string name, decimal price, string description, string category, int rating)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Rating = rating;
        }

        public bool MatchesCriteria(decimal minPrice, decimal maxPrice, string targetCategory, int minRating)
        {
            return Price >= minPrice && Price <= maxPrice
                && (string.IsNullOrEmpty(targetCategory) || Category.Equals(targetCategory, StringComparison.OrdinalIgnoreCase))
                && Rating >= minRating;
        }
    }
}
