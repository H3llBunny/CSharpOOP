using System.Net.NetworkInformation;

namespace SimpleFactoryExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Simple Factory pattern is a creational pattern that provides an interface
            for creating instances of a class, but leaves the choice of its type to the
            subclasses, creation being deferred at the time of instantiation.
            */

            SimpleFactory factory = new SimpleFactory();

            IProduct productA = factory.CreateProduct("A");
            productA.DesplayInfo();

            IProduct productB = factory.CreateProduct("B");
            productB.DesplayInfo();
        }
    }
}