using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace project
{
    class Program
    {
        // (a-b/c)*m
        // (a-b)*(a+b)
        // (a+b)*c-d*f+m/p
        static void Main(string[] args)
        { 
            string str = Console.ReadLine();
            RPN rPN = new RPN(str);
            var result = rPN.LengyelFormaKonvertalas();
            //var evaluateExpression= rPN.EvaluateExpression();
            Console.WriteLine(result);
            //Console.WriteLine(evaluateExpression);
        }

      
    }
}
