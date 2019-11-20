using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> inputRow = Console.ReadLine().Split(' ').ToList();
                string name = inputRow[0];
                List<double> grades = inputRow.Skip(1).Select(double.Parse).ToList();
                var newStudent = new Student(name, grades);
                students.Add(newStudent);
            }

            var studentWithExcelentAverageGrade = students
                .Where(s => s.Average() >= 5)
                .OrderBy(s => s.Name);


            foreach (var student in studentWithExcelentAverageGrade)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
