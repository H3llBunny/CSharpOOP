using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights[key] = new ConcreteFlyweight(key);
            }

            return flyweights[key];
        }
    }
}
