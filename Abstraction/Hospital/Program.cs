namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var hospitalRecords = new HospitalRecords();

            while ((input = Console.ReadLine()) != "Output")
            {
                var token = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string departmentName = token[0];
                string doctorName = token[1] + " " + token[2];
                string patientName = token[3];
                var currentPatient = new Patient(doctorName, patientName);
                var currentDepartment = new Department(currentPatient);
                hospitalRecords.Add(departmentName, currentDepartment);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (token.Length > 1)
                {
                    int parsedValue;
                    if (int.TryParse(token[1], out parsedValue))
                    {
                        PatientsInRoomPrinter(hospitalRecords, token);
                    }
                    else
                    {
                        string doctorName = token[0] + " " + token[1];
                        PatientsOfDoctorPrint(hospitalRecords, doctorName);
                    }
                }
                else
                {
                    string departmentName = token[0];
                    PrintOfDepartmentPatients(hospitalRecords, departmentName);
                }
            }
        }

        public static void PatientsInRoomPrinter(HospitalRecords hospitalRecords, string[] token)
        {
            int roomNumber = int.Parse(token[1]);
            string deparmentName = token[0];
            var orderedPatients = new List<string>();

            if (hospitalRecords.DepartmentList.ContainsKey(deparmentName))
            {
                var department = hospitalRecords.DepartmentList[deparmentName];

                foreach (var currentDepartment in department)
                {
                    if (currentDepartment.Patient.Room == roomNumber)
                    {
                        orderedPatients.Add(currentDepartment.Patient.PatientName);
                    }
                }

                foreach (var patient in orderedPatients.OrderBy(x => x))
                {
                    Console.WriteLine(patient);
                }
            }
        }

        public static void PatientsOfDoctorPrint(HospitalRecords hospitalRecord, string doctorName)
        {
            List<string> patients = new List<string>();

            foreach (var department in hospitalRecord.DepartmentList)
            {
                foreach (var patient in department.Value)
                {
                    if (patient.Patient.DoctorName == doctorName)
                    {
                        patients.Add(patient.Patient.PatientName);
                    }
                }
            }

            foreach (var patient in patients.OrderBy(x => x))
            {
                Console.WriteLine(patient);
            }
        }

        public static void PrintOfDepartmentPatients(HospitalRecords hospitalRecords, string departmentName)
        {
            if (hospitalRecords.DepartmentList.ContainsKey(departmentName))
            {
                var department = hospitalRecords.DepartmentList[departmentName];

                foreach (var currentDepartment in department)
                {
                    Console.WriteLine(currentDepartment.Patient.PatientName);
                }
            }
        }
    }
}
