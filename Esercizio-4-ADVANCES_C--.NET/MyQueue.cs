using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4_ADVANCES_C__.NET
{
    internal class MyQueue<T>
    {
        private LinkedList<T> items;

        public MyQueue()
        {
            items = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = items.First.Value;
            items.RemoveFirst();
            return item;

        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return items.First.Value;
        }
    }
}

