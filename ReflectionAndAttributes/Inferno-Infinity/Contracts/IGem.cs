using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Contracts
{
    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }
    }
}
