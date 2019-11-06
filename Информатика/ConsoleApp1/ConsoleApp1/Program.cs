using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void Task1()
        {
            List<string> inputs = Console.ReadLine().Split(',').ToList();
            inputs.Reverse();
            foreach (var input in inputs)
            {
                Console.WriteLine(input);
            }

        }

        static void Task2()
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            var reverseNumbers= new List<int>();
            foreach (var input in numbers)
            {
                reverseNumbers.Add(ReverseNumber(input));
            }
            Console.WriteLine(reverseNumbers.Sum());

        }

        static int ReverseNumber(int n)
        {
            Stack<int> number = new Stack<int>();
            while (n>0)
            {
                number.Push(n % 10);
                n = n / 10;
            }
            var newNumber = 0;

            while ( number.Count> 0)
            {
                var letter = number.Peek();
                newNumber = newNumber * 10 + letter;
            }
            return newNumber;
        }


    }
}
