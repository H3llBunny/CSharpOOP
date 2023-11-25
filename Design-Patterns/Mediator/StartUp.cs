namespace Mediator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Mediator pattern is a behavioral design pattern that defines an object (the mediator) 
            that centralizes communication between a set of objects (colleagues), thus promoting loose coupling between them.
            */

            // Create mediator
            var mediator = new ConcreteMediator();

            // Create colleagues and set the mediator
            var colleagueA = new ConcreteColleagueA(mediator);
            var colleagueB = new ConcreteColleagueB(mediator);

            mediator.ColleagueA = colleagueA;
            mediator.ColleagueB = colleagueB;

            // Colleague A sends a message
            colleagueA.Send("Hello from Colleague A");

            // Colleague B sends a message
            colleagueB.Send("Hi from Colleague B");

            /*
            The mediator knows how to communicate with each colleague, and colleagues communicate through the mediator, 
            promoting loose coupling. The Main method demonstrates creating a mediator, 
            creating colleagues, and having them send messages through the mediator.
            */
        }
    }
}