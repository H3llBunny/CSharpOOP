using Inferno_Infinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Commands
{
    public class PrintCommand : Command
    {
        private IRepository repository;

        public PrintCommand(string[] data) : base(data)
        {
        }

        public override void Execute()
        {
            string result = this.repository.PrintWeapon(this.Data[0]);

            Console.WriteLine(result);
        }
    }
}
