namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }

        public static void ReadNumber(int start, int end)
        {
            int count = 0;
            var numbers = new List<int>();

            while (count < 10)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (start >= number || number >= end)
                    {
                        throw new ArgumentException($"Your number is not in range {start} - 100!");
                    }

                    if (start < number && number < end)
                    {
                        numbers.Add(number);
                        start = number;
                        count++;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}