using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = Input();

            Console.WriteLine("Hello World!");
        }

        static Stack<int> Input()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            return stack;
        }


        static void  WriteNumbersAtTXT(Stack<int> numbers)
        {
            StreamWriter writer = new StreamWriter("numbers.txt");
            using(writer)
            {
                foreach (var number in numbers)
                {
                    writer.WriteLine(number);
                }
            }           
        }

        static void WriteNumbersWhitTree(Stack<int> numbers)
        {
            var count = 0;
            Console.WriteLine();
            foreach (var number in numbers)
            {
                var copyNumber = number;
                var flag = false;
                while (copyNumber>0)
                {
                    var ch = copyNumber % 10;
                    copyNumber = copyNumber / 10;
                    if (ch == 3) flag = true;
                }
                if(flag==true)
                {
                    count++;
                    Console.Write(number+" ");
                }
            }
            Console.WriteLine($"Count= {count}");

        }

    }
}
