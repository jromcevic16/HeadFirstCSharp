namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Hippo(),
                new Wolf(true),
                new Hippo(),
                new Wolf(false)
            };

            foreach(Animal animal in animals)
            {
                animal.MakeNoise();
                if(animal is ISwimmer swimmer)
                {
                    swimmer.Swim();
                }
                if(animal is IPackHunter packHunter)
                {
                    packHunter.HuntInPack();
                }
                Console.WriteLine();
            }
        }
    }
}
