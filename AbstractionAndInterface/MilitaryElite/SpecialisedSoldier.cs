using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corp) : base(id, firstName, lastName, salary)
        {
            if (corp == "Airforces" || corp == "Marines")
            {
                this.Corp = corp;
            }
            else
            {
                throw new ArgumentException("Invalid Corp");
            }
        }

        public string Corp { get; set; }
    }
}
