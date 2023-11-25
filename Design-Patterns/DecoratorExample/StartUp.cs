namespace DecoratorExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Decorator Design Pattern is a structural pattern that allows behavior to be 
            added to an individual object, either statically or dynamically, without affecting 
            the behavior of other objects from the same class. It is one of the Gang of Four 
            design patterns and is particularly useful for extending the 
            functionalities of classes in a flexible and reusable way.
            */

            ICar basicCar = new BasicCar();
            Console.WriteLine(basicCar.Assemble());

            ICar sportsCar = new SportsCar(basicCar);
            Console.WriteLine(sportsCar.Assemble());

            ICar luxurySportsCar = new LuxuryCar(new SportsCar(new BasicCar()));
            Console.WriteLine(luxurySportsCar.Assemble());
        }
    }
}