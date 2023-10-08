using System.Reflection;

namespace BlackBoxInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type classType = typeof(BlackBoxInteger);
            BlackBoxInteger instance = (BlackBoxInteger)Activator.CreateInstance(classType, true);
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var token = command.Split('_', StringSplitOptions.RemoveEmptyEntries);
                var methodName = token[0];
                var value = int.Parse(token[1]);

                classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .Invoke(instance, new object[] { value });

                int currentValue = (int)classType.GetField("innerValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(instance);

                Console.WriteLine(currentValue);
            }
        }
    }
}