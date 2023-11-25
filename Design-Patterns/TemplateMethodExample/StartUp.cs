namespace TemplateMethodExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Template Method pattern is a behavioral design pattern that defines the skeleton of an algorithm 
            in the superclass but lets subclasses override specific steps of the algorithm without changing its structure. 
            The template method pattern is used to define the program skeleton in a method in an algorithm, but delay some steps to subclasses.
            */

            AbstractClass abstractClass = new ConcreteClass();

            // Calling the template method, which triggers the steps defined in the algorithm
            abstractClass.TemplateMethod();
        }
    }
}