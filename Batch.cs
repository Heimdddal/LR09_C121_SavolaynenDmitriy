using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR09_C121_SavolaynenDmitriy
{
    internal class Batch : Product
    {
        private int _quantity;

        public Batch(string name, decimal price, int quantity, DateTime dateOfManufacting, DateTime bestBeforeDate):base(name, price, dateOfManufacting, bestBeforeDate)
        {
            _quantity = quantity;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Batch:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {_quantity}");
            Console.WriteLine($"Production Date: {dateOfManufacting.ToShortDateString()}");
            Console.WriteLine($"Expiration Date: {bestBeforeDate.ToShortDateString()}\n");
        }

        public override bool IsBest()
        {
            if (DateTime.Now < bestBeforeDate)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
            return DateTime.Now < bestBeforeDate;
        }
    }
}
