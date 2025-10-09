namespace IEnumerableDeepDive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManualSportSequence sports = new ManualSportSequence();
            foreach(var sport in sports)
            Console.WriteLine(sport);
        }
    }
}
