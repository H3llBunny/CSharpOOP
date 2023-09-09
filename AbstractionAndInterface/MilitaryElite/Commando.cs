using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corp) : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Missions { get; set; }

        public void AddMission(string missionName, string missionState)
        {
            if (missionState == "inProgress" || missionState == "Finished")
            {
                this.Missions.Add(missionName, missionState);
            }
            else
            {
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corp}");
            sb.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  Code Name: {mission.Key} State: {mission.Value}");
            }

            return sb.ToString();
        }
    }
}
