using System;
using System.Collections.Generic;
using System.Text;

namespace worker
{
    public class Salary
    {
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private double pay;

        public Salary(int month, double pay)
        {
            this.Month = month;
            this.Pay = pay;
        }

        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }


    }
}
