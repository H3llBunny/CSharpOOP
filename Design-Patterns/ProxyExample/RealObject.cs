using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    public class RealObject : IRealObject
    {
        public void Request()
        {
            Console.WriteLine("RealObject: Handling request.");
        }
    }
}
