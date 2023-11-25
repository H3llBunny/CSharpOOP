namespace LazyInitializationExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            Lazy Initialization is a design pattern that defers the creation of an
            object until it is actually needed. This can be useful in scenarios where 
            the creation of an object is resource-intensive or where the object might not be
            needed during the entire lifetime of the program. 
            The Lazy<T> class in C# is often used to implement lazy initialization.
            */

            LazyInitializationExample example = new LazyInitializationExample();

            Console.WriteLine("Lazy initialization example created.");

            ExpensiveResource resource = example.GetResource();
            resource.UseResource();

            ExpensiveResource resource2 = example.GetResource();
            resource2.UseResource();

            /*
            If the resource is not accessed, it is never created.
            In this example, the ExpensiveResource class represents a resource that 
            might be expensive to create. The LazyInitializationExample class 
            uses the Lazy<T> class to lazily initialize the ExpensiveResource. 
            The resource is only created when it is accessed via the GetResource method. 
            */
        }
    }
}