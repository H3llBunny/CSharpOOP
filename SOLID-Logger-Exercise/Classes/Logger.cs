using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Classes
{
    public class Logger : ILogger
    {
        private IList<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>();
            this.AddAppender(appenders);
        }

        public void AddAppender(IEnumerable<IAppender> appenders)
        {
            foreach (var appender in appenders)
            {
                this.appenders.Add(appender);
            }
        }

        public void Info(string dateTime, string message) => this.Log(dateTime, nameof(this.Info), message);

        public void Warning(string dateTime, string message) => this.Log(dateTime, nameof(this.Warning), message);

        public void Error(string dateTime, string message) => this.Log(dateTime, nameof(this.Error), message);

        public void Critical(string dateTime, string message) => this.Log(dateTime, nameof(this.Critical), message);

        public void Fatal(string dateTime, string message) => this.Log(dateTime, nameof(this.Fatal), message);

        private void Log(string dateTime, string reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Logger info");

            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString().Trim());
            }

            return sb.ToString();
        }
    }
}
