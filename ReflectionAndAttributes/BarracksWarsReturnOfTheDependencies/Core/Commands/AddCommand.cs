using BarracksWarsANewFactory.Contracts;
using BarracksWarsANewFactory.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;
      
        public AddCommand(string[] data) : base(data)
        {
        }

        public IRepository Repository
        {
            get => this.repository;
            set => this.repository = value;
        }

        public IUnitFactory UnitFactory
        {
            get => this.unitFactory;
            set => this.unitFactory = value;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
