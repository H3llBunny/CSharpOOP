using System;

namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double squareRoot = Math.Sqrt(number);
                Console.WriteLine(squareRoot);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}