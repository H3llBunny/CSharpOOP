using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram.Classes
{
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = 0;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; set; }

        protected int MessagesCount { get; set; }

        public abstract void Append(string dateTime, string reportLevel, string message);

        public bool ReportLevelValidator(string messageLevel)
        {
            var capitalizedLevel = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(messageLevel.ToLower());

            return (ReportLevel)Enum.Parse(typeof(ReportLevel), capitalizedLevel) >= this.ReportLevel;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}";
        }
    }
}
