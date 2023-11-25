namespace Observer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Observer pattern is a behavioral design pattern where an object, known as the subject, 
            maintains a list of dependents, known as observers, that are notified of any state 
            changes, typically by calling one of their methods.
            */

            // Create subject
            var subject = new ConcreteSubject();

            // Create observers
            var observerA = new ConcreteObserver("A", subject);
            var observerB = new ConcreteObserver("B", subject);

            // Change the state of the subject, and observers will be notified
            subject.State = "New State";

            /*
            Observers can attach to the subject, and when the subject's state changes, it notifies all its observers. 
            The Main method demonstrates creating a subject, creating observers, and changing the subject's 
            state to trigger observer notifications.
            */
        }
    }
}