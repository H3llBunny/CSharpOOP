using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(GemClarity clarity) 
            : base(clarity, 1, 4, 9)
        {
        }
    }
}
