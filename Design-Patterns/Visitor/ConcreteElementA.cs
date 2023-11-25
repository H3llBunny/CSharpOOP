using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("ConcreteElementA operation A");
        }
    }
}
