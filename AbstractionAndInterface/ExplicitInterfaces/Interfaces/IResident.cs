using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces.Interfaces
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }

        void GetName();
    }
}
