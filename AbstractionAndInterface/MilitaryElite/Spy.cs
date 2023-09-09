using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Spy : ISoldier, ISpy
    {
        public Spy(string firstName, string lastName, string id, int codeNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.CodeNumber = codeNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public int CodeNumber { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString();
        }
    }
}
