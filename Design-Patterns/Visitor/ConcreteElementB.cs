using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("ConcreteElementB operation B");
        }
    }
}
