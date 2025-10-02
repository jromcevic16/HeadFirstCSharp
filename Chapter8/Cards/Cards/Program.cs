namespace Cards
{
    internal class Program
    {

        private static Random random = new Random();
        static void Main(string[] args)
        {
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(card.Name);
        }
    }
}
