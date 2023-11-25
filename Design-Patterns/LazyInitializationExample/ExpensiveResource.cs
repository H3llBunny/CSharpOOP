using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitializationExample
{
    public class ExpensiveResource
    {
        public ExpensiveResource()
        {
            Console.WriteLine("Creating expensive resource...");
        }

        public void UseResource()
        {
            Console.WriteLine("Using expensive resource...");
        }
    }
}
