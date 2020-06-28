using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrom
{
    public class Number
    {
		private int inputNumber;

		public Number(int number)
		{
			this.InputNumber = number;
		}

		public int InputNumber
		{
			get { return inputNumber; }
			set { inputNumber = value; }
		}

		public string ChackPalindrome()
		{
            var stack = new Stack<int>();
            var queue = new Queue<int>();
            var number = this.InputNumber;
            do
            {
                var letter = number % 10;
                number /= 10;
                stack.Push(letter);
                queue.Enqueue(letter);
            } while (number > 0);

            if (IsPalindrome(stack, queue) == true)
            {
                return "палиндром";
            }
            return "не е палиндром";
		}

        private bool IsPalindrome(Stack<int> stack, Queue<int> queue)
        {
            while ((queue.Count > 0) && (stack.Count > 0))
            {
                if (stack.Peek() != queue.Peek())
                {
                    return false;
                }
                else
                {
                    queue.Dequeue();
                    stack.Pop();
                }
            }
            return true;
        }

    }
}
