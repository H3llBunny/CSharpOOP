using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class HospitalRecords
    {
        public Dictionary<string, List<Department>> DepartmentList { get; set; }

        public HospitalRecords()
        {
            this.DepartmentList = new Dictionary<string, List<Department>>();
        }

        public void Add(string departmentName, Department department)
        {
            if (DepartmentList.ContainsKey(departmentName))
            {
                var currentDepartment = DepartmentList[departmentName].LastOrDefault();
               
                if (currentDepartment.RoomCount < 21 && currentDepartment.BedCount < 3)
                {
                    currentDepartment.BedCount++;
                    department.Patient.Bed = currentDepartment.BedCount;
                    department.Patient.Room = currentDepartment.RoomCount;
                    department.BedCount = currentDepartment.BedCount;
                    department.RoomCount = currentDepartment.RoomCount;
                    DepartmentList[departmentName].Add(department);
                }
                else if (currentDepartment.RoomCount < 20 && currentDepartment.BedCount == 3)
                {
                    currentDepartment.RoomCount++;
                    currentDepartment.BedCount = 1;
                    department.Patient.Bed = currentDepartment.BedCount;
                    department.Patient.Room = currentDepartment.RoomCount;
                    department.RoomCount = currentDepartment.RoomCount;
                    department.BedCount = currentDepartment.BedCount;
                    DepartmentList[departmentName].Add(department);
                }

            }
            else
            {
                department.Patient.Room = 1;
                department.Patient.Bed = 1;
                department.BedCount++;
                department.RoomCount++;
                DepartmentList.Add(departmentName, new List<Department>() { department });
            }
        }
    }
}
