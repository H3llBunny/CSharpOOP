using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerProgram.Classes
{
    public class FileAppender : Appender
    {
        private const string FileName = "log.txt";
        private readonly string filePath;

        public FileAppender(ILayout layout) : base(layout)
        {
            this.filePath = Path.Combine(Environment.CurrentDirectory, FileName);
            this.File = new LogFile();
        }

        public ILogFile File { get; set; }

        public override void Append(string dateTime, string reportLevel, string message)
        {
            if (this.ReportLevelValidator(reportLevel))
            {
                var report = this.Layout.FormatReport(dateTime, reportLevel, message);
                this.File.Write(report);
                System.IO.File.AppendAllText(this.filePath, report);
                System.IO.File.AppendAllText(this.filePath, Environment.NewLine);
                this.MessagesCount++;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {this.File.Size}";
        }
    }
}
