using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car)
        {
        }

        public override string Assemble()
        {
            return base.Assemble() + ", Add Luxury Features";
        }
    }
}
