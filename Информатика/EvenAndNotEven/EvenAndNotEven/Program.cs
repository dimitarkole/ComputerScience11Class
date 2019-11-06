using System;
using System.IO;
using System.Linq;

namespace EvenAndNotEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Input();
            WriteEvenNumberAtFile(masiv);
            WriteOddNumberAtFile(masiv);
            Console.WriteLine("Готово!");
        }

        static void WriteEvenNumberAtFile(int[] masiv)
        {             
            StreamWriter writer = new StreamWriter("even.txt");
            using (writer)
            {
                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] % 2 == 0) writer.WriteLine(masiv[i]);
                }
            }
          
        }

        static void WriteOddNumberAtFile(int[] masiv)
        {
            StreamWriter writer = new StreamWriter("NotEven.txt");
            using (writer)
            {
                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] % 2 == 1) writer.WriteLine(masiv[i]);
                }
            }

        }

        static int[] Input()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return input;
        }
    }
}
