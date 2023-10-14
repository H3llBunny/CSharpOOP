using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Models.Weapons
{
    public class Knife : Weapon
    {
        public Knife(WeaponRarity rarity, string name) 
            : base(rarity, name, 3, 4, 2)
        {
        }
    }
}
