namespace Interpreter
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Interpreter pattern is a behavioral design pattern that defines a grammar for interpreting 
            the sentences in a language and provides an interpreter to interpret those sentences. 
            It's often used for creating a language interpreter or compiler.
            */

            // Context with input
            var context = new Context { Input = "10" };

            // Terminal expression
            AbstractExpression terminalExpression = new TerminalExpression();
            terminalExpression.Interpret(context);

            Console.WriteLine($"Terminal Expression Result: {context.Output}");

            // Non-terminal expression
            AbstractExpression nonTerminalExpression = new NonTerminalExpression();
            nonTerminalExpression.Interpret(context);

            Console.WriteLine($"Non-terminal Expression Result: {context.Output}");

            /*
            The Client creates a Context with an input string, and then interprets that input using a combination 
            of terminal and non-terminal expressions. The Interpreter pattern is useful when there is a need to 
            interpret sentences in a language and when the grammar of the language is relatively simple.
            */
        }
    }
}