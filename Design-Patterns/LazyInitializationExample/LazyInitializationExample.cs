using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitializationExample
{
    public class LazyInitializationExample
    {
        private Lazy<ExpensiveResource> lazyResource = new Lazy<ExpensiveResource>();

        public ExpensiveResource GetResource()
        {
            return lazyResource.Value;
        }
    }
}
