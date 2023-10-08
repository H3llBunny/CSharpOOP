using BarracksWarsANewFactory.Contracts;
using BarracksWarsANewFactory.CustomAttributes;
using BarracksWarsANewFactory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];

            try
            {
                this.repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }
    }
}
