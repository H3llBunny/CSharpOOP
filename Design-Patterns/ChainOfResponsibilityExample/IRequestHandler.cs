using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public interface IRequestHandler
    {
        IRequestHandler NextHandler { get; set; }
        void HandleRequest(Request request);
    }
}
