using Inferno_Infinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.data = data;
        }

        protected string[] Data { get { return this.data; } }

        public abstract void Execute();
    }
}
