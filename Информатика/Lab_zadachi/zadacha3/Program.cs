using System;
using System.Linq;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if(i%2==0)
                {
                    firstArray[counter] = input[1];
                    secondArray[counter] = input[0];
                    counter++;
                }
                else
                {
                    firstArray[counter] = input[0];
                    secondArray[counter] = input[1];
                    counter++;
                }
            }
            Console.WriteLine(string.Join(" ",firstArray));
            Console.WriteLine(string.Join(" ",secondArray));
        }
    }
}
