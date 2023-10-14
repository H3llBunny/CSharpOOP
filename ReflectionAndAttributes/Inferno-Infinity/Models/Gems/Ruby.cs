using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(GemClarity clarity) 
            : base(clarity, 7, 2, 5)
        {
        }
    }
}
