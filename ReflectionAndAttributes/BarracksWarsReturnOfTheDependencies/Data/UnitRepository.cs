using BarracksWarsANewFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Data
{
    public class UnitRepository : IRepository
    {
        private IDictionary<string, int> amountOfUnits;

        public UnitRepository()
        {
            this.amountOfUnits = new SortedDictionary<string, int>();
        }

        public string Statistics
        {
            get
            {
                var sb = new StringBuilder();

                foreach (var entry in amountOfUnits)
                {
                    sb.AppendLine($"{entry.Key} -> {entry.Value}");
                }

                return sb.ToString().Trim();
            }
        }

        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;

            if (!this.amountOfUnits.ContainsKey(unitType))
            {
                this.amountOfUnits.Add(unitType, 0);
            }

            this.amountOfUnits[unitType]++;
        }

        public void RemoveUnit(string unitType)
        {
            if (this.amountOfUnits.ContainsKey(unitType) && this.amountOfUnits[unitType] > 0)
            {
                this.amountOfUnits[unitType]--;
            }
            else
            {
                throw new ArgumentException("No such units in repository.");
            }
        }
    }
}
