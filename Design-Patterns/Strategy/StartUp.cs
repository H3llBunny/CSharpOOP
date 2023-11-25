namespace Strategy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Strategy pattern is a behavioral design pattern that defines a family of algorithms, 
            encapsulates each algorithm, and makes them interchangeable. Strategy lets the algorithm vary 
            independently from clients that use it.
            */

            // Create context with an initial strategy
            var context = new Context(new ConcreteStrategyA());

            // Execute the strategy
            context.ExecuteStrategy();

            // Change the strategy at runtime
            context.SetStrategy(new ConcreteStrategyB());

            // Execute the new strategy
            context.ExecuteStrategy();
        }
    }
}