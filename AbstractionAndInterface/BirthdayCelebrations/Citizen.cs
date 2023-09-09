using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen : Population
    {
        public Citizen(string name, string age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDay = birthDate;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }
        public string BirthDay { get; set; }

        public void BirthDate(string date, string birthDate)
        {
            if (date.EndsWith(birthDate))
            {
                Console.WriteLine(date);
            }
        }
    }
}

