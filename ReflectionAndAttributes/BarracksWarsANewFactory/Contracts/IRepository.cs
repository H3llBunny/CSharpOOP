using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Contracts
{
    public interface IRepository
    {
        string Statistics { get; }

        void AddUnit(IUnit unit);

        void RemoveUnit(string unitType);
    }
}
