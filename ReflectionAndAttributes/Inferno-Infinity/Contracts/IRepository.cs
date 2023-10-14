using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Contracts
{
    public interface IRepository
    {
        void AddWeapon(IWeapon weapon);

        void AddGem(string weaponName, int index, IGem gem);

        void RemoveGem(string weaponName, int index);

        string PrintWeapon(string name);
    }
}
