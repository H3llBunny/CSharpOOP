namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var citizens = new Citizen();
            var rebels = new Rebel();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                var token = command.Split();

                if (token.Length == 4)
                {
                    var name = token[0];
                    var age = int.Parse(token[1]);
                    var id = token[2];
                    var birthDate = token[3];
                    citizens.Add(name, age, id, birthDate);
                }
                else if (token.Length == 3)
                {
                    var name = token[0];
                    var age = int.Parse(token[1]);
                    var group = token[2];
                    rebels.Add(name, age, group);
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var name = input;

                foreach (var citizen in citizens.Citizens)
                {
                    if (citizen.Name == name)
                    {
                        citizens.Food += 10;
                    }
                }
                foreach (var rebel in rebels.Rebels)
                {
                    if (rebel.Name == name)
                    {
                        rebels.Food += 5;
                    }
                }
            }

            int totalFood = citizens.Food + rebels.Food;

            Console.WriteLine(totalFood);
        }
    }
}