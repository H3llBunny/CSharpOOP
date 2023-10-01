using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Classes
{
    public class SimpleLayout : ILayout
    {
        public string FormatReport(string dateTime, string reportLevel, string message) => $"{dateTime} - {reportLevel} - {message}";
    }
}
