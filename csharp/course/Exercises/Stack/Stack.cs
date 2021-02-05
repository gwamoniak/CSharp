using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack : IEnumerable
    {
        private object item;
        private List<object> list = new List<object>();

        public IEnumerator GetEnumerator()
        {
            while (list.Any())
                yield return Pop();
        }

        internal object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("List is empty");

            item = list.FirstOrDefault();

            list.RemoveAt(0);

            return item;
        }

        internal void Push(object obj)
        {
            item = obj;

            if (item == null)
                throw new InvalidOperationException($"{ nameof(item) } is null.There is nothing to Push().");

            list.Insert(0, item);
        }
        internal void Clear()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot clear empty list.");

            list.Clear();
        }

        public void Print()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }

    }
}
