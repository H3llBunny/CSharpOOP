namespace AdapterExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Adapter design pattern is used to allow two incompatible interfaces to 
            work together. It acts as a bridge between two incompatible interfaces, making 
            them compatible without changing their source code.

            Let's consider a simple example where we have an existing LegacyPrinter class with 
            a method called Print that takes a single string argument, and we want to use it in a 
            new system that expects objects implementing the INewPrinter interface with a method called PrintMessage.
            */

            LegacyPrinter legacyPrinter = new LegacyPrinter();

            INewPrinter newPrinter = new LegacyPrinterAdapter(legacyPrinter);

            newPrinter.PrintMessage("Hello, Adapter Pattern!");
        }
    }
}