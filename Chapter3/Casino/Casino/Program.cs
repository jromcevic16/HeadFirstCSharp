namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Cash = 100, Name = "Kipe"};
            Console.WriteLine("Welcome to the casion. The odds are " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    if (amount > 0)
                    {
                        int pot = player.GiveChase(amount) * 2;
                        if (odds < random.NextDouble())
                        {
                            player.ReciveCash(pot);
                            Console.WriteLine("You win " + pot);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
