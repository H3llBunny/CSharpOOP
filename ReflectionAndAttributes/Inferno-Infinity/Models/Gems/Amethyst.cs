using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(GemClarity clarity) 
            : base(clarity, 2, 8, 4)
        {
        }
    }
}
