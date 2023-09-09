using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public class Ferrari : CarFunctionality
    {
        public Ferrari(string name)
        {
            this.DriverName = name;
        }

        public string Model = "488-Sider";

        public string DriverName { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }
}
