using System.Diagnostics.Contracts;
using System.Numerics;

namespace BuilderExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Builder pattern is used to construct a complex object step by step. 
            It separates the construction of a complex object from its representation, 
            allowing the same construction process to create different representations. 
            */

            Director director = new Director();

            IBuilder builder1 = new ConcreteBuilder1();
            IBuilder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            Console.WriteLine("Product for Builder 1:");
            product1.ShowInfo();

            Console.WriteLine();

            director.Construct(builder2);
            Product product2 = builder2.GetResult();
            Console.WriteLine("Product for Builder 2:");
            product2.ShowInfo();
        }
    }
}