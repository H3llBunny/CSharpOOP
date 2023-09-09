using System;

namespace BirthdayCelebrations
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

                if (token[0] == "Robot")
                {
                    var model = token[1];
                    var id = token[2];
                    population.Add(new Robot(model, id));
                }
                else if (token[0] == "Citizen")
                {
                    var name = token[1];
                    var age = token[2];
                    var id = token[3];
                    var birthDay = token[4];
                    population.Add(new Citizen(name, age, id, birthDay));
                }
                else if (token[0] == "Pet")
                {
                    var name = token[1];
                    var birthDay = token[2];
                    population.Add(new Pet(name, birthDay));
                }
            }

            var birthDate = Console.ReadLine();

            foreach (var item in population)
            {
                if (item is Citizen)
                {
                    Citizen citizen = (Citizen)item;

                    if (citizen.BirthDay.EndsWith(birthDate))
                    {
                        Console.WriteLine(citizen.BirthDay);
                    }
                }
                else if (item is Pet)
                {
                    Pet pet = (Pet)item;

                    if (pet.BirthDay.EndsWith(birthDate))
                    {
                        Console.WriteLine(pet.BirthDay);
                    }
                }
            }
        }
    }
}