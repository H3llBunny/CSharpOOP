using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Commands
{
    public class EndCommand : Command
    {
        public EndCommand(string[] data) : base(data)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
