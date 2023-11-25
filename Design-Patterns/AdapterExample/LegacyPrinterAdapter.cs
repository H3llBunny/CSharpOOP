using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class LegacyPrinterAdapter : INewPrinter
    {
        private LegacyPrinter legacyPrinter;

        public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
        {
            this.legacyPrinter = legacyPrinter;
        }

        public void PrintMessage(string message)
        {
            legacyPrinter.Print(message);
        }
    }
}
