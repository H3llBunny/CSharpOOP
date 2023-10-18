namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cards = new List<Card>();
            var cardsInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var card in cardsInput)
            {
                string face = card.Split().FirstOrDefault();
                string suit = card.Split().Skip(1).FirstOrDefault();

                try
                {
                    Card currentCard = new Card(face, suit);
                    cards.Add(currentCard);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(string.Join(" ", cards));
        }
    }
}