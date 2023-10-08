using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.ModelsOfUnits
{
    public class Swordsman : Unit
    {
        private const int DefaultHealth = 40;
        private const int DefaultDamage = 13;

        public Swordsman() : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
