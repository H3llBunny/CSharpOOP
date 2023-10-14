using Inferno_Infinity.Contracts;
using Inferno_Infinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Factories
{
    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string clarity, string gemType)
        {
            GemClarity gemClarity = (GemClarity)Enum.Parse(typeof(GemClarity), clarity);

            Type classType = Type.GetType("Inferno_Infinity.Models.Gems." + gemType);

            IGem instance = (IGem)Activator.CreateInstance(classType, new object[] { gemClarity });

            return instance;
        }
    }
}
