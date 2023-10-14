using Inferno_Infinity.Contracts;
using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Factories
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string weaponRarity, string weaponType, string name)
        {
            WeaponRarity rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), weaponRarity);

            Type classType = Type.GetType("Inferno_Infinity.Models.Weapons." + weaponType);

            IWeapon instance = (IWeapon)Activator.CreateInstance(classType, new object[] { rarity, name });

            return instance;
        }
    }
}
