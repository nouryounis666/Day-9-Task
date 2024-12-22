using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Part02.Class
{
    internal class Stack<T>
    {
        private List<T> elements = new List<T>();

        #region Stack Methods
        public void Push(T item)
        {
            elements.Add(item);
        }

        public T Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            return elements[elements.Count - 1];
        }

        public int Count => elements.Count;
        #endregion
    }
}


