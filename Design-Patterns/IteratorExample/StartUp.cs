namespace IteratorExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Iterator pattern is a behavioral design pattern that provides a way to access the 
            elements of an aggregate object sequentially without exposing its underlying representation.
            */

            string[] names = { "Alice", "Bob", "Charlie", "David" };

            // Create an aggregate
            IAggregate<string> aggregate = new ConcreteAggregate<string>(names);

            // Create an iterator
            IIterator<string> iterator = aggregate.CreateIterator();

            // Iterate over the elements
            while (iterator.HasNext())
            {
                string name = iterator.Next();
                Console.WriteLine(name);
            }
            /*
            The Iterator pattern decouples the client code from the internal structure of the aggregate, 
            allowing the client to iterate over elements without knowing the details of how they are stored or accessed. 
            This promotes a clean separation of concerns and enhances the flexibility of the code.
            */
        }
    }
}