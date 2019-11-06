using System;
using System.Linq;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        static void Task1()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                    Console.Write("{0,10}",matrix[i, j]);
                }
                Console.Write("{0,10}",sum/m);
                Console.WriteLine();
            }
        }

        static void Task2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                int[] inputMasiv = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = inputMasiv[j];
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,10}",matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        
            for (int j = 0; j < m; j++)
            {
                int min = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                   if(min>matrix[i, j]) min= matrix[i,j];
                }
                Console.Write("{0,10}", min);
                Console.WriteLine();
            }
        }
    }
}
