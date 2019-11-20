using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Average_Grades
{
    public class Student
    {
        public Student()
        {
            Grades = new List<double>();
        }
        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        private string name{ get; set; }

        private List<double> grades { get; set; }

        public List<double> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Average()
        {
            return Grades.Sum()/Grades.Count;
        }

        public override string ToString()
        {
            return $"{this.Name} -> {this.Average():f2}";
        }
    }
}

