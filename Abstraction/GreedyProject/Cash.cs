using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProject
{
    public class Cash
    {
        public Cash()
        {
            this.CashCurrencies = new Dictionary<string, long>();
        }
        public Dictionary<string, long> CashCurrencies { get; set; }

        public void Add(string currency, long amount)
        {
            if (CashCurrencies.ContainsKey(currency))
            {
                CashCurrencies[currency] += amount;
            }
            else
            {
                CashCurrencies.Add(currency, amount);
            }
        }
    }
}
