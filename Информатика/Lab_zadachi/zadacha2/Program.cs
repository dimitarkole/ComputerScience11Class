using System;
using System.Linq;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p = Console.ReadLine().Split(' ');
            string[] m = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < p.Length ; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (p[i] == m[j])
                        Console.Write(p[i] + " ");
                }
            }

        }
    }
}
