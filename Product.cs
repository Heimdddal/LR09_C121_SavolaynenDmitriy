using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR09_C121_SavolaynenDmitriy
{
    internal abstract class Product
    {
        protected string name;
        protected decimal price;
        protected DateTime dateOfManufacting;
        protected DateTime bestBeforeDate;

        public Product(string name, decimal price, DateTime dateOfManufacting, DateTime bestBeforeDate)
        {
            this.name = name;
            this.price = price;
            this.dateOfManufacting = dateOfManufacting;
            this.bestBeforeDate = bestBeforeDate;
        }
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract void PrintInfo();

        public virtual bool IsBest()
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

        public string Name
        {
            get { return name; }
        }

        public DateTime BestBeforeDate
        {
            get { return bestBeforeDate; }
        }
    }
}
