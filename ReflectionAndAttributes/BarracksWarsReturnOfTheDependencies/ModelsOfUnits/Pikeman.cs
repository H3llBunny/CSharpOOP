using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.ModelsOfUnits
{
    public class Pikeman : Unit
    {
        private const int DefaultHealth = 30;
        private const int DefaultDamage = 15;

        public Pikeman() : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
