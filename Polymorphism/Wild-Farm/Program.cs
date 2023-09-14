using WildFarm.Animal_Classes;
using WildFarm.Food_Classes;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();
            var food = new List<IFood>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var animalToken = command.Split();
                var animalType = animalToken[0];
                var animalName = animalToken[1];
                var animalWeight = double.Parse(animalToken[2]);

                switch (animalType)
                {
                    case "Owl":
                        var owlWingSize = double.Parse(animalToken[3]);
                        animals.Add(new Owl(animalName, animalWeight, owlWingSize));
                        break;

                    case "Hen":
                        var henWingSize = double.Parse(animalToken[3]);
                        animals.Add(new Hen(animalName, animalWeight, henWingSize));
                        break;

                    case "Mouse":
                        var mouseLivingRegion = animalToken[3];
                        animals.Add(new Mouse(animalName, animalWeight, mouseLivingRegion));
                        break;

                    case "Dog":
                        var dogLivingRegion = animalToken[3];
                        animals.Add(new Dog(animalName, animalWeight, dogLivingRegion));
                        break;

                    case "Cat":
                        var catLivingRegion = animalToken[3];
                        var catBreed = animalToken[4];
                        animals.Add(new Cat(animalName, animalWeight, catLivingRegion, catBreed));
                        break;

                    case "Tiger":
                        var tigerLivingRegion = animalToken[3];
                        var tigerBreed = animalToken[4];
                        animals.Add(new Tiger(animalName, animalWeight, tigerLivingRegion, tigerBreed));
                        break;

                    default:
                        break;
                }

                var foodToken = Console.ReadLine().Split();
                var foodType = foodToken[0];
                var foodQuantity = int.Parse(foodToken[1]);

                switch (foodType)
                {
                    case "Vegetable":
                        food.Add(new Vegetable(foodQuantity));
                        break;

                    case "Fruit":
                        food.Add(new Fruit(foodQuantity));
                        break;

                    case "Meat":
                        food.Add(new Meat(foodQuantity));
                        break;

                    case "Seeds":
                        food.Add(new Seeds(foodQuantity));
                        break;

                    default:
                        break;
                }
            }

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].Sound();
                animals[i].Eat(food[i]);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}