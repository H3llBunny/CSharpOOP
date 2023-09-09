using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : PhoneNumber, WebSite
    {
        public Smartphone()
        {
            
        }

        public List<string> PhoneNumbers { get; set; }
        public List<string> WebSites { get; set; }

        public void PhoneNumber(string number)
        {
            double phoneNumber;

            if(double.TryParse(number, out phoneNumber))
            {
                if(number.Length == 10)
                {
                    Console.WriteLine("Calling... {0}", number);
                }
                else
                {
                    Console.WriteLine("Dialing... {0}", number);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void WebSite(string webSite)
        {
            if (!webSite.Any(char.IsDigit))
            {
                Console.WriteLine("Browsing: {0}!", webSite);
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}
