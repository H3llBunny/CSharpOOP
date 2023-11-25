namespace ChainOfResponsibilityExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Chain of Responsibility pattern is a behavioral design pattern that 
            lets you pass requests along a chain of handlers. Upon receiving a request, each handler 
            decides either to process the request or to pass it to the next handler in the chain.
            */

            // Create handlers
            IRequestHandler handler1 = new ConcreteHandler1();
            IRequestHandler handler2 = new ConcreteHandler2();

            // Set up the chain
            handler1.NextHandler = handler2;
            handler2.NextHandler = handler1;

            // Create requests
            Request request1 = new Request(RequestLevel.Level1);
            Request request2 = new Request(RequestLevel.Level2);

            // Process requests
            handler1.HandleRequest(request1);
            handler1.HandleRequest(request2);
        }
    }
}