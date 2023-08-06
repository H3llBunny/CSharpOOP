namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfPeople = new Person();
            var listOfProducts = new List<Product>();
            var peopleInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                for (int i = 0; i < peopleInput.Length; i++)
                {
                    string name = peopleInput[i];
                    double money = double.Parse(peopleInput[i + 1]);
                    var person = new Person(name, money, new List<string>());
                    listOfPeople.Add(person);
                    i++;

                }

                var productsInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productsInput.Length - 1; i++)
                {
                    string name = productsInput[i];
                    double price = double.Parse(productsInput[i + 1]);
                    var product = new Product(name, price);
                    listOfProducts.Add(product);
                    i++;

                }

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    var token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = token[0];
                    string productName = token[1];
                    listOfPeople.TryPurchaseProduct(personName, listOfProducts.FirstOrDefault(x => x.Name == productName));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(listOfPeople);
        }
    }
}