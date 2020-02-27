using System;
using System.Collections.Generic;
using System.Text;

namespace TransportSuytem
{
    public class Product
    {
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private int kolichestvo;

        public int Кolichestvo
        {
            get { return kolichestvo; }
            set { kolichestvo = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public Product(string barcode, int kolichestvo, string name, double price)
        {
            Barcode = barcode;
            Кolichestvo = kolichestvo;
            Name = name;
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            var result = "баркод= " + Barcode+ " име= " + Name + " цена= " + Price + " количество= " + Кolichestvo;
            return base.ToString(); 
        }
    }
}
