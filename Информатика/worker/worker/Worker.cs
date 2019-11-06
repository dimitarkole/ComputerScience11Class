using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace worker
{
    public class Worker
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private List<Salary> salaries;

        public Worker(string name, int age, List<Salary> salaries)
        {
            Name = name;
            Age = age;
            Salaries = salaries;
        }

        public List<Salary> Salaries
        {
            get { return salaries; }
            set { salaries = value; }
        }

        public double GetSalaryForMouth(int mouth)
        {
            double salary = this.Salaries.FirstOrDefault(s=>s.Month==mouth).Pay;
            return salary;
        }
        public override string ToString()
        {
            var result = $"{this.Name} { this.Age}";
            return result;
        }

    }
}
