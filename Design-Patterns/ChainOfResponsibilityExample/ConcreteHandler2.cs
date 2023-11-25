using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class ConcreteHandler2 : IRequestHandler
    {
        public IRequestHandler NextHandler { get; set; }

        public void HandleRequest(Request request)
        {
            if (request.Level == RequestLevel.Level2)
            {
                Console.WriteLine("ConcreteHandler2 handles the request.");
            }
            else if (NextHandler != null)
            {
                Console.WriteLine("ConcreteHandler2 passes the request to the next handler.");
                NextHandler.HandleRequest(request);
            }
        }
    }
}
