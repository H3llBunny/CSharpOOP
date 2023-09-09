using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corp) : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Repairs { get; set; }

        public void AddRepair(string partName, int hoursWorked)
        {
            this.Repairs.Add(partName, hoursWorked);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corp}");
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
            }

            return sb.ToString();
        }
    }
}
