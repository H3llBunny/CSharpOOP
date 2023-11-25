using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class ConcreteBuilder1 : IBuilder
    {
        private Product product = new Product();

        public void BuildPart1()
        {
            product.Part1 = "Part 1 for Builder 1";
        }

        public void BuildPart2()
        {
            product.Part2 = "Part 2 for Builder 1";
        }

        public Product GetResult()
        {
            return this.product;
        }
    }
}
