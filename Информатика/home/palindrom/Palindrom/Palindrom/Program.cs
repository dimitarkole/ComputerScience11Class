using System;
using System.Collections;
using System.Collections.Generic;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber =0;
            while (inputNumber < 10 || inputNumber > 1000001)
            {
                Console.WriteLine("Въведете число в интервала [10..1000001]: ");
                inputNumber = int.Parse(Console.ReadLine());
            }
            Number number = new Number(inputNumber);
            var result = number.ChackPalindrome();
            Console.WriteLine(result); 
        }
    }
}
