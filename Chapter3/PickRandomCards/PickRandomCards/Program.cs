namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            Console.Write("Enter the number of cards to pick: ");
            while (!isNumber)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out int numberOfCards))
                {
                    isNumber = true;
                    foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                    {
                        Console.WriteLine(card);
                    }
                }
                else
                {
                    Console.Write("Please Enter a valide number: ");
                }
            }
        }
    }
}
