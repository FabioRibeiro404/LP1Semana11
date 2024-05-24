using System;
using System.Collections;
using System.Collections.Generic;

namespace FilaLimitada
{
    public class LimitedQueue<T> : ICollection<T>
    {
        private readonly LinkedList<T> _items;
        private readonly int _capacity;

        public LimitedQueue(int capacity = 5)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero", nameof(capacity));

            _capacity = capacity;
            _items = new LinkedList<T>();
        }

        public int Count => _items.Count;
        
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (_items.Count == _capacity)
            {
                _items.RemoveFirst();
            }
            _items.AddLast(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }


        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

    }
}
