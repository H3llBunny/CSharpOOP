using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Interfaces
{
    public interface ILayout
    {
        string FormatReport(string dateTime, string reportLevel, string message);
    }
}
