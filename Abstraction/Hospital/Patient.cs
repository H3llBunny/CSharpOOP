using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient
    {
        public int Room = 0;
        public int Bed = 0;

        public Patient(string doctorName, string patientName)
        {
            this.DoctorName = doctorName;
            this.PatientName = patientName;
        }

        public string DoctorName { get; set; }
        public string PatientName { get; set; }
    }
}
