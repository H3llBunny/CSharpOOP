using System;

namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                var token = Console.ReadLine().Split();
                var command = token[0];

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            int index = int.Parse(token[1]);
                            int num = int.Parse(token[2]);

                            if (0 <= index && index < numbers.Length)
                            {
                                numbers[index] = num;
                            }
                            else
                            {
                                throw new IndexOutOfRangeException();
                            }
                            break;
                        case "Print":
                            int startIndex = int.Parse(token[1]);
                            int endIndex = int.Parse(token[2]);

                            if (startIndex >= 0 && startIndex < endIndex
                                && endIndex < numbers.Length)
                            {
                                var numsInRange = new List<int>();

                                for (int i = startIndex; i <= endIndex; i++)
                                {
                                    numsInRange.Add(numbers[i]);
                                }

                                Console.WriteLine(string.Join(", ", numsInRange));
                            }
                            else
                            {
                                throw new IndexOutOfRangeException();
                            }
                            break;
                        case "Show":
                            int printIndex = int.Parse(token[1]);

                            if (printIndex >= 0 && printIndex < numbers.Length)
                            {
                                Console.WriteLine(numbers[printIndex]);
                            }
                            else
                            {
                                throw new IndexOutOfRangeException();
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}