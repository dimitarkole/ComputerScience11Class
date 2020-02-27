using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        private Model model;

        public Model Model
        {
            get { return model; }
            set { model = value; }
        }

        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

    }
}
