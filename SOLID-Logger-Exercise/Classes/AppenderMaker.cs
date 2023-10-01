using LoggerProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace LoggerProgram.Classes
{
    public class AppenderMaker
    {
        public IAppender CreateAppender(string appenderName, string layoutName)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var layoutType = types.FirstOrDefault(t => t.Name == layoutName);
            var appenderType = types.FirstOrDefault(t => t.Name == appenderName);

            var layout = (ILayout)Activator.CreateInstance(layoutType);
            var appender = (IAppender)Activator.CreateInstance(appenderType, new object[] { layout });

            return appender;
        }
    }
}
