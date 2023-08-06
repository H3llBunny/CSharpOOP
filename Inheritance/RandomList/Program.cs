namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");
            randomList.RemoveRandomElement();
            randomList.RemoveRandomElement();
            Console.WriteLine(randomList.Count());
            Console.WriteLine(randomList.GetRandomElement());
        }
    }
}