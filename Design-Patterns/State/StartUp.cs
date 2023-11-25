namespace State
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The State pattern is a behavioral design pattern that allows an object to alter its behavior when 
            its internal state changes. The pattern encapsulates the state-specific behavior in separate classes and 
            delegates the responsibility for changing state to these classes.
            */

            // Create context with initial state ConcreteStateA
            var context = new Context(new ConcreteStateA());

            // Perform some requests, which will cause the state to change
            context.Request();
            context.Request();
            context.Request();

            /*
            The Context delegates the request to its current state, and the state, in turn, can change the 
            context's state based on its logic. This allows the object to alter its behavior when its internal state changes.

            The State pattern is useful when an object's behavior depends on its state, and the state can change 
            during the object's lifecycle. It promotes encapsulation of state-specific behavior and makes it easy to 
            add new states without modifying the context class.
            */
        }
    }
}