namespace FactoryMethodExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Factory Method pattern is a creational pattern that provides an interface
            for creating objects in a superclass but allows subclasses to alter the type of objects that will be created.
            */

            ICreator creatorA = new ConcreteCreatorA();
            IProduct productA = creatorA.FactoryMethod();
            productA.DisplayInfo();

            ICreator creatorB = new ConcreteCreatorB();
            IProduct productB = creatorB.FactoryMethod();
            productB.DisplayInfo();
        }
    }
}