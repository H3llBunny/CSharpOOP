﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Interfaces
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string message);
    }
}
