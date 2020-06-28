using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueAleko
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Въведи брой");
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            Queue<int> opashka = new Queue<int>();

            Queue<int> evenopashka = new Queue<int>();
            Queue<int> oddopashka = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                opashka.Enqueue(num);
                if (num % 2 == 0)
                {
                    evenopashka.Enqueue(num);
                }
                else
                {
                    oddopashka.Enqueue(num);
                }
            }
            while (oddopashka.Count > 0)
            {
                Console.Write(oddopashka.Dequeue() + ", ");

            }
            Console.WriteLine();
            while (evenopashka.Count > 0)
            {
                Console.Write(evenopashka.Dequeue() + ", ");
            }
            Console.WriteLine();
            while (opashka.Count > 0)
            {
                Console.Write(opashka.Dequeue() + ", ");
            }
        }


       /* static void Main(string[] args)
        {

            var numbersList = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();
            Queue<int> opashka = new Queue<int>(numbersList);
            Queue<int> opashkaChetni = new Queue<int>();
            Queue<int> opashkaNechetni = new Queue<int>();
            Queue<int> opashka2= new Queue<int>();


            while (opashka.Count > 0)
            {
                int chislo = opashka.Dequeue();
                opashka2.Enqueue(chislo);
                if (chislo % 2 == 1) opashkaChetni.Enqueue(chislo);
                else opashkaNechetni.Enqueue(chislo);
            }
            Console.WriteLine("Четни елементи: ");
            while (opashkaChetni.Count > 0)
            {
                int chislo = opashkaChetni.Dequeue();
                Console.Write(chislo);
            }
            Console.WriteLine();
            Console.WriteLine("Нечетни елементи: ");
            while (opashkaNechetni.Count > 0)
            {
                int chislo = opashkaNechetni.Dequeue();
                Console.Write(chislo);
            }

            Console.WriteLine();
            Console.WriteLine("Всички елементи: ");
            while (opashka2.Count > 0)
            {
                int chislo = opashka2.Dequeue();
                Console.Write(chislo);
            }
        }*/
    }
}
