using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Console.ReadLine().Replace(",", "").Split(' ').Select(int.Parse).ToList();
            Queue<int> numbersQueue = new Queue<int>(numbersList);
            Console.WriteLine($"нечетни числa: {string.Join(", ", numbersQueue.Where(x=> x%2==1))}");
            Console.WriteLine($"четни числa: {string.Join(", ", numbersQueue.Where(x=> x%2==0))}");
            Console.WriteLine($"числата съответства на реда на въвеждането им: {string.Join(", ", numbersQueue)}");

        }
    }
}
