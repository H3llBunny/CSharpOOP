using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Contracts
{
    public interface IGemFactory
    {
        IGem CreateGem(string clarity, string gemType);
    }
}
