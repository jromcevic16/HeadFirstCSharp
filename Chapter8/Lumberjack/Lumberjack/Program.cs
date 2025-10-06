namespace Lumberjack
{
    internal class Program
    {
        public static Random Random = new Random();
        static void Main(string[] args)
        {
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
            Console.Write("First lumberjack's name: ");
            string name = Console.ReadLine();
            while (name != "")
            {
                Console.Write("Number of flapjacks: ");
                Lumberjack lumberjack = new Lumberjack(name);
                if (int.TryParse(Console.ReadLine(), out int flapjeckNumber))
                    for (int i = 0; i < flapjeckNumber; i++)
                        lumberjack.TakeFlapjack((Flapjack)Random.Next(4));
                lumberjacks.Enqueue(lumberjack);
                Console.Write("Next lumberjack's name (blank to end): ");
                name = Console.ReadLine();
            }
            foreach(Lumberjack lj in lumberjacks)
            {
                Console.WriteLine($"{lj.Name} is eating flapjacks");
                lj.EatAllFlapjacks();
            }
        }
    }
}
