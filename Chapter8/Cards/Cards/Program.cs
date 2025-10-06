using System.Collections.Generic;

namespace Cards
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            List<Card> Cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    Cards.Add(RandomCard());
                }
            }
            PrintCards(Cards);
            Console.WriteLine("\n... sorting the cards ...\n");
            Cards.Sort(new CardComparerByValue());
            PrintCards(Cards);
        }

        public static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }
        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
