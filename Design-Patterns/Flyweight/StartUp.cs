namespace Flyweight
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Flyweight design pattern is a structural pattern that aims to minimize memory usage 
            or computational expenses by sharing as much as possible with related objects. 
            It is particularly useful when there are a large number of similar objects in an application.
            */

            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweight1 = factory.GetFlyweight("A");
            IFlyweight flyweight2 = factory.GetFlyweight("B");
            IFlyweight flyweight3 = factory.GetFlyweight("A");

            flyweight1.Operation(1);
            flyweight1.Operation(2);
            flyweight1.Operation(3);
        }
    }
}