using LoggerProgram.Classes;
using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerProgram
{
    public class CommandInterpreter
    {
        private IList<IAppender> appenders;
        private AppenderMaker appenderMaker;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderMaker = new AppenderMaker();
        }

        internal void GetAppendersFromConsole()
        {
            var appenderNum = int.Parse(Console.ReadLine());

            while (appenderNum > 0)
            {
                var token = Console.ReadLine().Split();
                var appenderName = token[0];
                var lauoutName = token[1];

                var appender = this.appenderMaker.CreateAppender(appenderName, lauoutName);

                if (token.Length > 2)
                {
                    SetLevelThreshold(appender, token[2]);
                }

                this.appenders.Add(appender);
                appenderNum--;
            }
        }

        internal void ExecuteCommands()
        {
            var command = Console.ReadLine().Split('|');

            while (command[0] != "END")
            {
                var reportLevel = command[0];
                var time = command[1];
                var message = command[2];

                foreach (var appender in this.appenders)
                {
                    appender.Append(time, reportLevel, message);
                }

                command = Console.ReadLine().Split('|');
            }
        }

        internal void PrintAppenders()
        {
            foreach (var appender in this.appenders)
            {
                Console.WriteLine(appender.ToString().Trim());
            }
        }

        private void SetLevelThreshold(IAppender appender, string thresholdName)
        {
            ReportLevel levelThreshold;
            var isValidLevel = Enum.TryParse(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(thresholdName.ToLower()), out levelThreshold);

            if (isValidLevel)
            {
                appender.ReportLevel = levelThreshold;
            }
        }
    }
}
