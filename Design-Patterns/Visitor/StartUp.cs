namespace Visitor
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Visitor pattern is a behavioral design pattern that allows you to define a new operation 
            without changing the classes of the elements on which it operates. 
            It's used when you have a set of elements with different types, and you want to perform a specific 
            operation on each of these elements without modifying their classes.
            */

            var elements = new List<IElement>
            {
                new ConcreteElementA(),
                new ConcreteElementB()
            };

            var visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            /*
            The Client creates a list of elements and a concrete visitor. It then iterates through the elements, 
            and for each element, it calls the Accept method, passing the visitor. The visitor, in turn, performs specific 
            operations on each element without changing the element classes.

            This pattern is useful when you have a set of classes with different types, and you want to define 
            new operations on these classes without modifying their code. It promotes separation of concerns and allows you to 
            add new operations without modifying existing code.
            */
        }
    }
}