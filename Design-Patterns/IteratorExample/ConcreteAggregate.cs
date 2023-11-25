using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly T[] _items;

        public ConcreteAggregate(T[] items)
        {
            _items = items;
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }
}
