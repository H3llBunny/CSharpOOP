namespace PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (pizzaInput.Length < 2)
                {
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                    return;
                }

                string pizzaName = pizzaInput[1];
                var doughInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string doughType = doughInput[1];
                string bakingTechnique = doughInput[2];
                double doughGrams = double.Parse(doughInput[3]);
                var dough = new Dough(doughType, bakingTechnique, doughGrams);
                var pizza = new Pizza(pizzaName, dough);
                string toppingInput;

                while ((toppingInput = Console.ReadLine()) != "END")
                {
                    var toppingSplit = toppingInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingSplit[1];
                    double toppingGrams = double.Parse(toppingSplit[2]);
                    var topping = new Topping(toppingType, toppingGrams);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.PizzaName} - {pizza.Calories():f2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}