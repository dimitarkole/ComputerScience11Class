using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportSuytem
{
    static class Shop
    {
        static private List<Product> products;

        static public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        static void Sell(string barcode, int Кolichestvo)
        {
            var product = Products.FirstOrDefault(p => p.Barcode == barcode);
            if (product == null) Console.WriteLine("Not enough quantity");
            if (product.Кolichestvo > Кolichestvo) product.Кolichestvo -= Кolichestvo;

        }


        static void Add(Product newProduct)
        {
            Products.Add(newProduct);
        }

        static void Update(string barcode, int colichestvo)
        {
            var product = Products.FirstOrDefault(p => p.Barcode == barcode);
            if (product == null) Console.WriteLine("Pleace add your product first!");
            product.Кolichestvo += colichestvo;
        }

        static void Print()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        static void Calculate()
        {
            var allPrice = products.Sum(x => x.Price * x.Кolichestvo);
            Console.WriteLine(allPrice);
        }
    }
}
