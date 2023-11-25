using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }
}
