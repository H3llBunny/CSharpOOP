using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        int BaseMinDamage { get; }

        int BaseMaxDamage { get; }

        void AddGem(int index, IGem gem);

        void RemoveGem(int index);

        IReadOnlyCollection<IGem> Slots { get; }
    }
}
