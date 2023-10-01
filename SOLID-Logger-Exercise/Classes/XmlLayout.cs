using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Classes
{
    public class XmlLayout : ILayout
    {
        public string FormatReport(string dateTime, string reportLevel, string message)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine($"    <date>{dateTime}</date>");
            sb.AppendLine($"    <level>{reportLevel}</level>");
            sb.AppendLine($"    <message>{message}</message>");
            sb.AppendLine("</log>");

            return sb.ToString().Trim();
        }
    }
}
