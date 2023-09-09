using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen : Population
    {
        public Citizen(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }

        public void FakeIdCheck(string id, string fakeIdDigits)
        {
            if (id.EndsWith(fakeIdDigits))
            {
                Console.WriteLine(id);
            }
        }
    }
}

