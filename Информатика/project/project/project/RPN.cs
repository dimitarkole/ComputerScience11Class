using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace project
{
    public class RPN
    {
        public RPN(string expression)
        {
            this.Expression = expression;
        }

        public string Expression { get; set; }

        public string LengyelFormaKonvertalas()
        {
            DynamicStack<char> stack = new DynamicStack<char>();
            string str = this.Expression.Replace(" ", string.Empty);
            StringBuilder formula = new StringBuilder();

            foreach (var element in str)
            {
                if (element == '(')
                    stack.Push(element);
                else if (element == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        formula.Append(stack.Pop());
                    stack.Pop();
                }
                else if (IsOperandus(element))
                {
                    formula.Append(element);
                }
                else if (IsOperator(element))
                {
                    while (stack.Count > 0 && stack.Peek() != '(' && Prior(element) <= Prior(stack.Peek()))
                        formula.Append(stack.Pop());
                    stack.Push(element);
                }
                else
                {
                    char y = stack.Pop();
                    if (y != '(')
                        formula.Append(y);
                }
            }
            while (stack.Count > 0)
            {
                formula.Append(stack.Pop());
            }
            return formula.ToString();
        }

        public double EvaluateExpression()
        {
            var letters = this.Expression.Select(x => IsOperandus(x) == true ? x : ' ' ).GroupBy(x => x).Select(y => y.First()).OrderBy(x=>x).ToList();
            var expressionWithNumbers = "";
            var valuetsOfLetters = new List<double>();
            foreach (var letter in letters)
            {
                if(letter!= ' ')
                {
                    Console.WriteLine($"{letter} = ");
                    var value = double.Parse(Console.ReadLine());
                    valuetsOfLetters.Add(value);
                }
             
            }

            foreach (var letter in this.Expression)
            {
                if(IsOperandus(letter))
                {
                    var value = valuetsOfLetters[letters.IndexOf(letter)-1];
                    expressionWithNumbers += value;
                }
                else
                {
                    expressionWithNumbers += letter;
                }
            }
            Console.WriteLine("expresionWithNumbers = "+ expressionWithNumbers);
            var evaluateExpression = this.Evaluate1(expressionWithNumbers);
            return evaluateExpression;
        }


        private bool IsOperator(char c)
        {
            return (c == '-' || c == '+' || c == '*' || c == '/');
        }

        private bool IsOperandus(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private int Prior(char c)
        {
            switch (c)
            {
                case '=':
                    return 1;
                case '+':
                    return 2;
                case '-':
                    return 2;
                case '*':
                    return 3;
                case '/':
                    return 3;
                case '^':
                    return 4;
                default:
                    throw new ArgumentException("Rossz parameter");
            }
        }

        private double Evaluate1(string expression)
        {
            return (double)new System.Xml.XPath.XPathDocument
            (new StringReader("<r/>")).CreateNavigator().Evaluate
            (string.Format("number({0})", new
            System.Text.RegularExpressions.Regex(@"([\+\-\*])")
            .Replace(expression, " ${1} ")
            .Replace("/", " div ")
            .Replace("%", " mod ")));
        }

        private double Evaluate(string expression)
        {
            return Convert.ToDouble(new DataTable().Compute(expression, null));
        }
    }
}
