namespace Ferrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string driverName = Console.ReadLine();
                Ferrari ferrari = new Ferrari(driverName);

                Console.WriteLine($"{ferrari.Model}/{ferrari.Brakes()}/{ferrari.Gas()}/{ferrari.DriverName}");
            }
        }
    }
}