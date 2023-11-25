using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Method that uses the strategy
        public void ExecuteStrategy()
        {
            strategy.Execute();
        }

        // Method to change the strategy at runtime
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}
