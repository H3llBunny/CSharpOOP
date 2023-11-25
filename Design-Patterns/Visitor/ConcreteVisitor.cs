using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void VisitElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("Visitor is performing operation on ConcreteElementA");
            elementA.OperationA();
        }

        public void VisitElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("Visitor is performing operation on ConcreteElementB");
            elementB.OperationB();
        }
    }
}
