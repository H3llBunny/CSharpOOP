using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly T[] _items;
        private int _currentIndex;

        public ConcreteIterator(T[] items)
        {
            _items = items;
            _currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _items.Length;
        }

        public T Next()
        {
            if (HasNext())
            {
                T currentItem = _items[_currentIndex];
                _currentIndex++;
                return currentItem;
            }
            else
            {
                throw new InvalidCastException("No more elements to iterate.");
            }
        }
    }
}
