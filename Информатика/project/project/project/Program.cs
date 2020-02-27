using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace project
{
    class Program
    {
        // "(a-b/c)*m";

        static void Main(string[] args)
        {
            string str = "(a-b/c)*m";
            RPN rPN = new RPN(str);
            var result = rPN.LengyelFormaKonvertalas();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
