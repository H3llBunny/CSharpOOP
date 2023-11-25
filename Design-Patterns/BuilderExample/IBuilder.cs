using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();

        Product GetResult();
    }
}
