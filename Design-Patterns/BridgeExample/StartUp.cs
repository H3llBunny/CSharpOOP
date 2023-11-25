namespace BridgeExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Bridge design pattern is a structural pattern that separates the abstraction 
            from its implementation so that both can vary independently. 
            This pattern involves an interface (abstraction) and a concrete class (implementor) that 
            are loosely coupled by providing a bridge structure between them.
            */

            Shape circle1 = new Circle(new VectorRenderer(), 5);
            Shape circle2 = new Circle(new RasterRenderer(), 3);

            Shape square1 = new Square(new VectorRenderer(), 4);
            Shape square2 = new Square(new RasterRenderer(), 6);

            circle1.Draw();
            circle2.Draw();
            square1.Draw();
            square2.Draw();

            /*
            Explanation:

            The Shape class represents the abstraction, and it has a reference to the IRenderer interface.
            The IRenderer interface represents the implementor, defining methods for rendering circles and squares.
            The VectorRenderer and RasterRenderer are concrete implementor classes that implement the IRenderer interface.
            The Circle and Square classes are refined abstractions that extend the Shape class and provide specific 
            implementations for drawing circles and squares.
            The Bridge pattern allows the abstraction (shape) and implementation (renderer) to vary independently. 
            It promotes flexibility and extensibility by enabling new shapes and renderers to be added without modifying existing code.
            */
        }
    }
}