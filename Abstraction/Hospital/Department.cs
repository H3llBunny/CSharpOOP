using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Department
    {
        public int RoomCount = 0;
        public int BedCount = 0;

        public Department(Patient patient)
        {
            this.Patient = patient;
        }

        public Patient Patient { get; set; }
    }
}
