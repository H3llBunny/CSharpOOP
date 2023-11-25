using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class ConcreteHandler1 : IRequestHandler
    {
        public IRequestHandler NextHandler { get; set; }

        public void HandleRequest(Request request)
        {
            if (request.Level == RequestLevel.Level1)
            {
                Console.WriteLine("ConcreteHandler1 handles the request.");
            }
            else if (NextHandler != null)
            {
                Console.WriteLine("ConcreteHandler1 passes the request to the next handler.");
                NextHandler.HandleRequest(request);
            }
        }
    }
}
