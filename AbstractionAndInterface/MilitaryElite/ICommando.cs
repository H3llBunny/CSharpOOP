using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public interface ICommando
    {
        public Dictionary<string, string> Missions { get; set; }

        void AddMission(string missionName, string missionState);
    }
}
