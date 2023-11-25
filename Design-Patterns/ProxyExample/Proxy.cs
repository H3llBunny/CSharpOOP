using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    public class Proxy : IRealObject
    {
        private RealObject realObject;

        public void Request()
        {
            // Lazy initialization: create the RealObject only when needed
            if (realObject == null)
            {
                realObject = new RealObject();
            }

            // Additional behavior before delegating to the RealObject
            Console.WriteLine("Proxy: Logging the request.");

            // Delegating the request to the RealObject
            realObject.Request();

            // Additional behavior after delegating to the RealObject
            Console.WriteLine("Proxy: Request handled.");
        }
    }
}
