namespace Memento
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Memento pattern is a behavioral design pattern that allows an object's state to 
            be captured and restored at a later time without exposing its internal structure. 
            This is particularly useful when you need to implement undo functionality or save and restore the state of an object.
            */

            // Create originator
            var originator = new Originator();

            // Set initial state
            originator.State = "State1";

            // Save state in a memento
            var caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            // Change state
            originator.State = "State2";

            // Restore state from the memento
            originator.RestoreMemento(caretaker.Memento);

            Console.WriteLine("Current state: " + originator.State);

            /*
            In this example, Memento is the memento class that stores the state of the Originator. 
            Originator is the object whose state needs to be saved and restored. Caretaker is responsible for 
            keeping track of the memento. The Main method demonstrates creating an originator, setting its state, 
            creating a memento, changing the state, and then restoring the state from the memento.

            The Memento pattern allows you to encapsulate the internal state of an object and restore 
            it to a previous state without exposing the details of its implementation.
            */
        }
    }
}