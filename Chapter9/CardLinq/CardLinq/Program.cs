using CardsLinq;

namespace CardLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck().Shuffle().cards.Take(16);
            IOrderedEnumerable<IGrouping<Suits, Card>> groupd = groupBy(deck);
            foreach (var group in groupd)
            {
                Console.WriteLine($@"Group: {group.Key}
Count: {group.Count()}
Minimum: {group.Min()}
Maximum: {group.Max()}");
            }
            Console.WriteLine("Hello, World!");
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> groupBy(IEnumerable<Card> deck)
        {
            return from card in deck
                   group card by card.Suit into suitGroup
                   orderby suitGroup.Key descending
                   select suitGroup;
        }
    }
}
