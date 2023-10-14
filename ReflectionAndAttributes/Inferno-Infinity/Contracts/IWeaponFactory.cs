using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Contracts
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string weaponRarity, string weaponType, string name);
    }
}
