using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string GetRandomElement()
        {
            var elementIndex = random.Next(0, this.Count);
            return this[elementIndex];
        }

        public string RemoveRandomElement()
        {
            var elementIndex = random.Next(0, this.Count);
            var element = this[elementIndex];
            this.RemoveAt(elementIndex);
            return element;
        }
    }
}
