using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class DinamicStack<T>
    {
        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }

            public Node(T item)
            {
                this.Item = item;
                this.Next = null;
            }

            public Node(T item, Node next)
            {
                this.Item = item;
                this.Next = next;
            }
        }

        private Node top;
        private int count;

        public DinamicStack()
        {
            this.top = null;
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(T item)
        {
            if (this.top == null)
            {
                // We have empty stack
                this.top = new Node(item);
            }
            else
            {
                Node newNode = new Node(item, this.top);
                this.top = newNode;
            }

            this.count++;
        }

        public T Peek()
        {
            if (this.count == 0)
            {
                // We have empty stack
                throw new InvalidOperationException("The stack is empty");
            }

            return this.top.Item;
        }

        public T Pop()
        {
            if (this.count == 0)
            {
                // We have empty stack
                throw new InvalidOperationException("The stack is empty");
            }

            T result = this.top.Item;
            this.top = this.top.Next;
            this.count--;

            return result;
        }

        public void Clear()
        {
            this.top = null;
            this.count = 0;
        }

        public T[] ToArray()
        {
            T[] result = new T[this.count];

            Node currentNode = this.top;
            for (int i = 0; i < this.count; i++)
            {
                result[i] = currentNode.Item;
                currentNode = currentNode.Next;
            }

            return result;
        }
    }
}
