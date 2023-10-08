using BarracksWarsANewFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Type classType = Type.GetType("BarracksWarsANewFactory.ModelsOfUnits." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
