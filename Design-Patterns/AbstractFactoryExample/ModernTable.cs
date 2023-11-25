using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class ModernTable : ITable
    {
        public void Display()
        {
            Console.WriteLine("Modern Table is displayed.");
        }
    }
}
