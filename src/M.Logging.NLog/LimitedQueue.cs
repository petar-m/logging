using System.Collections;
using System.Collections.Generic;

namespace M.Utilities.Logging
{
    internal class LimitedQueue<T> : IEnumerable<T>
    {
        private readonly Queue<T> queue;

        public LimitedQueue(int maxSize)
        {
            MaxSize = maxSize;
            queue = new Queue<T>();
        }

        public int MaxSize
        {
            get;
            private set;
        }

        public int Count => queue.Count;

        public T Peek => queue.Peek();

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
            if (queue.Count > MaxSize)
            {
                queue.Dequeue();
            }
        }

        public T Dequeue => queue.Dequeue();

        public IEnumerator<T> GetEnumerator()
        {
            return queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)queue).GetEnumerator();
        }
    }
}
