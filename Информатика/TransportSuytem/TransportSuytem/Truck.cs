
namespace TransportSuytem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Truck
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }

        private double loadCapacity;

        public double LoadCapacity
        {
            get { return loadCapacity; }
            set
            {
                if (value < 0) throw new ArgumentException("Weight cannot be negative");
                loadCapacity = value;
            }
        }

        private List<Freight> freights;

        public Truck(string name, double loadCapacity)
        {
            Name = name;
            LoadCapacity = loadCapacity;
            Freights = new List<Freight>();
        }

        public List<Freight> Freights 
        {
            get { return freights; }
            set { freights = value; }
        }

        public void AddFreights(Freight freight )
        {
            var sumWeith = this.Freights.Sum(f => f.Мass) + freight.Мass;
            if (sumWeith > this.LoadCapacity)
            {
                Console.WriteLine($"{this.name} can't loaded {freight.Name}");
            }
        }

        public override string ToString()
        {
            var result = this.Name+" - " + string.Join(" ,", this.Freights);
            return result;
        }
    }
}
