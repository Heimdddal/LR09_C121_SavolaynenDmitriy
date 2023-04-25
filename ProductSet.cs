using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR09_C121_SavolaynenDmitriy
{
    internal class ProductSet : ProductItem
    {
        private List<ProductItem> _products;
        private List<string> _names = new List<string>();
        private List<DateTime> _bestBeforeDate = new List<DateTime>();
        private List<ProductItem> _notValidProducts = new List<ProductItem>();

        public ProductSet(string name, decimal price, List<ProductItem> products):base(name, price) 
        {
            _products = products;
        }

        private void GetNames()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                _names.Add(_products[i].Name);
            }
        }

        private void GetDates()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                _bestBeforeDate.Add(_products[i].BestBeforeDate);
            }
        }

        private void NotValidProducts()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].BestBeforeDate < DateTime.Now)
                {
                    _notValidProducts.Add(_products[i]);
                }
            }
        }

        public void GetNotValidProducts()
        {
            NotValidProducts();
            foreach (var product in _notValidProducts)
            {
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Date:" + product.BestBeforeDate.ToString());
            }
        }

        public override void PrintInfo()
        {
            GetNames();
            GetDates();
            Console.WriteLine("Product Set:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Products: {string.Join(",", _names)}");
            Console.WriteLine($"Expiration Date: {_bestBeforeDate.Min().ToShortDateString()}\n");
        }

        public override bool IsBest()
        {
            GetDates();
            if (DateTime.Now < _bestBeforeDate.Min())
            {
                Console.WriteLine(name + " - Valid");
            }
            else
            {
                Console.WriteLine(name + " - Not valid");
            }
            return DateTime.Now < _bestBeforeDate.Min();
        }
    }
}
