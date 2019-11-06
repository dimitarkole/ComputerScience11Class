using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var id = int.Parse(Console.ReadLine());
                var name = Console.ReadLine();
                var uspeh = double.Parse(Console.ReadLine());

                var student = new Student(id,name,uspeh);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Uspeh} {student.IsExelent()}");
            }
        }
    }
}
