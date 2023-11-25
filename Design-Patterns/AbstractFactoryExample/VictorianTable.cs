using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class VictorianTable : ITable
    {
        public void Display()
        {
            Console.WriteLine("Victorian Table is displayed.");
        }
    }
}
