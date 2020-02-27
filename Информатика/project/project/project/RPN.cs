using System;
using System.Collections.Generic;
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
            for (int i = 0; i < str.Length; i++)
            {
                char x = str[i];
                if (x == '(')
                    stack.Push(x);
                else if (x == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        formula.Append(stack.Pop());
                    stack.Pop();
                }
                else if (IsOperandus(x))
                {
                    formula.Append(x);
                }
                else if (IsOperator(x))
                {
                    while (stack.Count > 0 && stack.Peek() != '(' && Prior(x) <= Prior(stack.Peek()))
                        formula.Append(stack.Pop());
                    stack.Push(x);
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
    }
}
