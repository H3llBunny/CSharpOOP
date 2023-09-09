using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : Population
    {
        public Pet(string name, string birthDate)
        {
            this.PetName = name;
            this.BirthDay = birthDate;
        }

        public string PetName { get; set; }
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
