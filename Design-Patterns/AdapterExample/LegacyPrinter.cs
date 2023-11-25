using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class LegacyPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine("Legaxy Printer: " + message);
        }
    }
}
