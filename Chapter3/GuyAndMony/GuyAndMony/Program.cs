namespace GuyAndMony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if(int.TryParse(howMuch, out int result))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe")
                    {
                        if(joe.GiveChase(result) != 0)
                        {
                            bob.ReciveCash(result);
                        }
                    }
                    else if(whichGuy == "Bob")
                    {
                        if (bob.GiveChase(result) != 0)
                        {
                            joe.ReciveCash(result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
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
