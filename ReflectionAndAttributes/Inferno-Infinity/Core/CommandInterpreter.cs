using Inferno_Infinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public IExecutable InterpreterCommand(string commandName, string[] data)
        {
            string name = commandName.ToUpper().First() + commandName.ToLower().Substring(1) + "Command";

            Type classType = Type.GetType("Inferno_Infinity.Core.Commands." + name);

            IExecutable instance = (IExecutable)Activator.CreateInstance(classType, new object[] { data });

            return instance;
        }
    }
}
