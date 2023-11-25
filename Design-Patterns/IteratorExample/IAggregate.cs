﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
