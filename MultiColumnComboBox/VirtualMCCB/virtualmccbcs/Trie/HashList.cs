using System;
using System.Collections.Generic;

namespace TrieImplementation
{
    /// <summary>
    /// Represents the HashSet from .net 3.5 - http://msdn.microsoft.com/en-us/library/bb359438.aspx
    /// </summary>
    /// <typeparam name="T">T</typeparam>
    public class HashList<T> : ICollection<T>
    {
        protected const int DEFAULT_CAPACITY = 500;

        protected Dictionary<T, byte> items;

        public HashList()
            : this(DEFAULT_CAPACITY)
        {
        }

        public HashList(int capacity)
            : this(capacity, EqualityComparer<T>.Default)
        {
        }

        public HashList(int capacity, IEqualityComparer<T> comparer)
        {
            this.items = new Dictionary<T, byte>(capacity, comparer);
        }

        public void Add(T item)
        {
            if (!this.items.ContainsKey(item))
            {
                this.items.Add(item, 0);
            }
        }

        public void Clear()
        {
            this.items.Clear();
        }

        public bool Contains(T item)
        {
            return this.items.ContainsKey(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.items.Keys.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return this.items.Keys.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            if (this.items.ContainsKey(item))
            {
                this.items.Remove(item);
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in this.items.Keys)
            {
                if (object.Equals(obj, default(T)))
                {
                    continue;
                }

                yield return obj;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
