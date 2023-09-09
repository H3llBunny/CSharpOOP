using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Robot : Population
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }

        public void BirthDate(string date, string birthDate)
        {
            if (date.EndsWith(birthDate))
            {
                Console.WriteLine(date);
            }
        }
    }
}
