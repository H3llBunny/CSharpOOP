using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
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

        public void FakeIdCheck(string id, string fakeIdDigits)
        {
            if (id.EndsWith(fakeIdDigits))
            {
                Console.WriteLine(id);
            }
        }
    }
}
