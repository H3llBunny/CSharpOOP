using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class ModernChair : IChair
    {
        public void Display()
        {
            Console.WriteLine("Modern Chair is displayed.");
        }
    }
}
