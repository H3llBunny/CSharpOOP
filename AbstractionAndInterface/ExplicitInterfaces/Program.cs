using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var citizens = new List<Citizen>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split();
                string name = token[0];
                string country = token[1];

                var citizen = new Citizen(name, country);

                citizens.Add(citizen);
            }

            foreach (var person in citizens)
            {
                person.GetName();
                ((IResident)person).GetName();
            }
        }
    }
}