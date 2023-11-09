using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetMarket
{
    public class Product
    {
        public string Category { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public int Price { get; set; }
        public double Diagonal { get; set; }
        public void DoInf()
        {
            Console.WriteLine($"{Category} {Model} {Price}");
        }
        public void DoAddPrice(string Category)
        {
            int result = 0;
            Console.WriteLine("Укажите количество товаров");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Category == "Smartphone" || Category == "smartphone" && count >= 5)
            {
                result = (Price * count) - (Price / 100 * 7);
            }
            if (Category == "Tablet" || Category == "tablet" && count >= 5)
            {
                result = (Price * count) - (Price / 100 * 9);
            }
            if (Category == "Laptop" || Category == "laptop" && count >= 5)
            {
                result = (Price * count) - (Price / 100 * 5);
            }
            else
            {
                result = Price * count;
            }
            Console.WriteLine(result);
        }
    }
}
