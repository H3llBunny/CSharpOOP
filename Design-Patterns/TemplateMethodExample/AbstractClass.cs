using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    abstract class AbstractClass
    {
        // The template method that defines the algorithm
        public void TemplateMethod()
        {
            StepOne();
            StepTwo();
            StepThree();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void StepOne();
        protected abstract void StepTwo();

        // A hook method that can be overridden (but is optional)
        protected virtual void StepThree()
        {
            Console.WriteLine("Default implementation of StepThree");
        }
    }
}
