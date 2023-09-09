namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var population = new List<Population>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split();

                if (token.Length == 2)
                {
                    var model = token[0];
                    var id = token[1];
                    population.Add(new Robot(model, id));
                }
                else
                {
                    var name = token[0];
                    var age = token[1];
                    var id = token[2];
                    population.Add(new Citizen(name, age, id));
                }
            }

            var fakeId = Console.ReadLine();

            foreach (var person in population)
            {
                if (person is Citizen)
                {
                    Citizen citizen = (Citizen)person;

                    if (citizen.Id.EndsWith(fakeId))
                    {
                        Console.WriteLine(citizen.Id);
                    }
                }
                else if (person is Robot)
                {
                    Robot robot = (Robot)person;

                    if (robot.Id.EndsWith(fakeId))
                    {
                        Console.WriteLine(robot.Id);
                    }
                }
            }
        }
    }
}