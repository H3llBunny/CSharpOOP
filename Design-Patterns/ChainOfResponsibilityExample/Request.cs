using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class Request
    {
        public RequestLevel Level { get; }

        public Request(RequestLevel level)
        {
            Level = level;
        }
    }
}

public enum RequestLevel
{
    Level1,
    Level2,
}
