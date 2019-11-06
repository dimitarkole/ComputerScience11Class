using System;
using System.Collections.Generic;

namespace worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of workers:");
            int n = int.Parse(Console.ReadLine());
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Age:");

                int age = int.Parse(Console.ReadLine());
                List<Salary> salaries = new List<Salary>();
                Console.WriteLine("Input count salarys");
                int countSalarys = int.Parse(Console.ReadLine());
                for (int j = 0; j < countSalarys; j++)
                {
                    Console.WriteLine("Input month");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input pay");
                    double pay = double.Parse(Console.ReadLine());
                    Salary salary = new Salary(month, pay);
                    salaries.Add(salary);
                }
                Worker worker = new Worker(name,age, salaries);
                workers.Add(worker);
            }

            for (int i = 0; i < n; i++)
            {
                Worker worker = workers[i];
                Console.WriteLine("Input month for searching salary");
                int month = int.Parse(Console.ReadLine());

                double salary = worker.GetSalaryForMouth(month);
                Console.WriteLine($"{worker.ToString()} - {salary} for {month}");
            }
        }
    }
}
