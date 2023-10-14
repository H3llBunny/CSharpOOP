using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Models.Weapons
{
    public class Axe : Weapon
    {
        public Axe(WeaponRarity rarity, string name) 
            : base(rarity, name, 5, 10, 4)
        {
        }
    }
}
