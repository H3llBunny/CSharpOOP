using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Interfaces
{
    public interface ILogger
    {
        void Error(string dateTime, string parsingMethod);
        void Info(string dateTime, string message);
        void Fatal(string dateTime, string message);
        void Critical(string dateTime, string message);
    }
}
