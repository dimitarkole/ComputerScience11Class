using System;

namespace Lab_zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] vagoni = new int[n];
            for (int i = 0; i < n; i++)
            {
                vagoni[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += vagoni[i];
            }
            Console.WriteLine(string.Join(" ", vagoni));
            Console.WriteLine(sum);
            
        }
    }
}
