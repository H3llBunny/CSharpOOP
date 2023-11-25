using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ConcreteFlyweight : IFlyweight
    {
        private string intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            this.intrinsicState = intrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            Console.WriteLine($"Concrete Flyweight: Intrinsic State = {intrinsicState}, Extrinsic State = {extrinsicState}");
        }
    }
}
