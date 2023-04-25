namespace LR09_C121_SavolaynenDmitriy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2002, 4, 1);
            DateTime dateBest = new DateTime(2005, 8, 1);
            DateTime date1 = new DateTime(2003, 8, 1);
            DateTime dateBest1 = new DateTime(2008, 8, 1);
            DateTime date2 = new DateTime(2010, 8, 1);
            DateTime dateBest2 = new DateTime(2015, 8, 1);
            DateTime date3 = new DateTime(2018, 2, 4);
            DateTime dateBest3 = new DateTime(2026, 8, 24);

            ProductItem newproduct = new ProductItem("Apple", 1000, date, dateBest);
            ProductItem newproduct1 = new ProductItem("Tomat", 1500, date1, dateBest1);
            ProductItem newproduct2 = new ProductItem("Cucumber", 1800, date2, dateBest2);
            Batch newbatch = new Batch("Oranges", 1800m, 5, date3, dateBest3);

            List<ProductItem> set = new List<ProductItem>();
            set.Add(newproduct);
            set.Add(newproduct1);
            set.Add(newproduct2);

            ProductSet newproductset = new ProductSet("Products", 1000, set);
            
            newproduct.PrintInfo();
            newproduct1.PrintInfo();
            newproduct2.PrintInfo();
            newbatch.PrintInfo();
            newproductset.PrintInfo();
            newproductset.IsBest();
            newproduct.IsBest();
            newproduct1.IsBest();
            newproduct2.IsBest();
            newbatch.IsBest();
            newproductset.IsBest();
            newproductset.GetNotValidProducts();
        }
    }
}