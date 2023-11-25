using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class VictorianChair : IChair
    {
        public void Display()
        {
            Console.WriteLine("Victorian Chair is displayed.");
        }
    }
}
