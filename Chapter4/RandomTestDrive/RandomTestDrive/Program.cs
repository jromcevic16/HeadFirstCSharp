namespace RandomTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);
            int dieROLL = random.Next(1,7);
            Console.WriteLine(dieROLL);
            double randomdouble = random.NextDouble();
            Console.WriteLine(randomdouble * 100);
            Console.WriteLine((float)randomdouble * 100F);
            Console.WriteLine((decimal)randomdouble * 100M);
            int zeroOrOne = random.Next(2);
            bool cointFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(cointFlip);

        }
    }
}
