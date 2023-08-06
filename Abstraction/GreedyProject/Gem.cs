using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProject
{
    public class Gem
    {
        public Gem()
        {
            this.Gems = new Dictionary<string, long>();
        }

        public Dictionary<string, long> Gems { get; set; }

        public void Add(string gem, long amount)
        {
            if (Gems.ContainsKey(gem))
            {
                Gems[gem] += amount;
            }
            else
            {
                Gems.Add(gem, amount);
            }
        }
    }
}
