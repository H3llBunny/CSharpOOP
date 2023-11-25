﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        void VisitElementA(ConcreteElementA elementA);
        void VisitElementB(ConcreteElementB elementB);
    }
}
