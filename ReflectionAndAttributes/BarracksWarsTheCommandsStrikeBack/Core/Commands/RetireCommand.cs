using BarracksWarsANewFactory.Contracts;
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
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];

            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }

        }
    }
}
