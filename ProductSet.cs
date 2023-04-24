using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR09_C121_SavolaynenDmitriy
{
    internal class ProductSet : ProductItem
    {
        private List<ProductItem> _products;

        public ProductSet(string name, decimal price, List<ProductItem> products):base(name, price) 
        {
            _products = products;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Product Set:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Products: {string.Join(",", _products.Select(name => name.Name()}");
            Console.WriteLine($"Expiration Date: {bestBeforeDate.ToShortDateString()}");
        }
    }
    }
}
