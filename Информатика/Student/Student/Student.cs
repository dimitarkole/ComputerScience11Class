using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        public Student()
        { }

        public Student(int id, string name, double uspeh)
        {
            Name = name;
            Id = id;
            Uspeh = uspeh;
        }

        public string Name { get; private set; }

        public int Id { get; private set; }

        public double Uspeh { get; private set; }

        public bool IsExelent(){
            if (this.Uspeh >= 5.5) return true;
            return false;
        }

    }
}
