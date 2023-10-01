using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Classes
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string dateTime, string reportLevel, string message)
        {
            if (this.ReportLevelValidator(reportLevel))
            {
                Console.WriteLine(this.Layout.FormatReport(dateTime, reportLevel, message));
                this.MessagesCount++;
            }
        }
    }
}
