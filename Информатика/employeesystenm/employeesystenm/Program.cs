using System;
using System.Collections.Generic;

namespace employeesystenm
{
    class Program
    {
        public struct Emploee
        {
            public string Name;
            public double Salary;
            public int staj;
        }

        static void Main(string[] args)
        {

            Stack<Emploee> Emploees = new Stack<Emploee>();
            int n = int.Parse(Console.ReadLine());
            Emploee emploee = new Emploee();

            for (int i = 0; i < n; i++)
            {
                emploee.Name =Console.ReadLine();
                emploee.Salary = double.Parse(Console.ReadLine());
                emploee.staj = int.Parse(Console.ReadLine());
                emploee.Salary = emploee.Salary * (1 + emploee.staj / 100);
                Emploees.Push(emploee);
            }


            do
            {
                emploee = Emploees.Pop();
                Console.WriteLine($"{emploee.Name} {emploee.Salary} {emploee.staj}");

            } while (true);
        }
    }
}
