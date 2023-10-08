using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);

        string Statistics { get; }

        void RemoveUnit(string unitType);
    }
}
