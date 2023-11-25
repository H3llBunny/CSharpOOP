using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Handling request in ConcreteStateB");
            // Change the state to ConcreteStateA
            context.State = new ConcreteStateA();
        }
    }
}
