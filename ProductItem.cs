using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR09_C121_SavolaynenDmitriy
{
    internal class ProductItem : Product
    {
        public ProductItem(string name, decimal price, DateTime dateOfManufacting, DateTime bestBeforeDate) : base(name, price, dateOfManufacting, bestBeforeDate)
        {
        }
        public ProductItem(string name, decimal price) : base(name, price)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Product:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Production Date: {dateOfManufacting.ToShortDateString()}");
            Console.WriteLine($"Expiration Date: {bestBeforeDate.ToShortDateString()}");
        }
    }
}
