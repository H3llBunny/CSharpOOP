using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public abstract class BaseHero : IHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
            this.Power = 0;
        }

        public string Name { get; set; }
        public int Power { get; set; }

        public abstract string CastAbility();
    }
}
