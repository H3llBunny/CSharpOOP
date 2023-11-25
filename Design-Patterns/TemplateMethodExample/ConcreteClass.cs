using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    class ConcreteClass : AbstractClass
    {
        // Concrete subclass implementing the template method
        protected override void StepOne()
        {
            Console.WriteLine("StepOne in ConcreteClass");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("StepTwo in ConcreteClass");
        }

        // Optionally overriding the hook method
        protected override void StepThree()
        {
            Console.WriteLine("Custom implementation of StepThree in ConcreteClass");
        }
    }
}
