using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> inputNumbers = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int count = 0;
            
            StreamWriter writer = new StreamWriter("number.txt");
            
            using(writer)
            {
                foreach (var number in inputNumbers)
                {
                    var numberCopy = Math.Abs(number);
                    var flag = false;
                    do
                    {
                        var ch = numberCopy % 10;
                        if(ch % 2 == 0)
                        {
                            flag = true;
                            break;
                        }
                        numberCopy /= 10;
                    } while (numberCopy>0);

                    if(flag == true)
                    {
                        count++;
                        writer.WriteLine(number);
                    }
                }
                Console.WriteLine("Count=" + count);
            }
        }
    }
}
