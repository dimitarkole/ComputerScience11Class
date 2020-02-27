namespace TransportSuytem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Freight
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

        private double mass;

        public Freight(string name, double мass)
        {
            Name = name;
            Мass = мass;
        }

        public double Мass
        {
            get { return mass; }
            set {
                if (value < 0) throw new ArgumentException("Weight cannot be negative");
                mass = value; 
            }
        }

    }
}
