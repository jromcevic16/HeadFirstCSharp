namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            tallGuy.Honk();

            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescriptio());
            fingersTheClown.Honk();
            IScaryClown iScaryClownReference = fingersTheClown as IScaryClown;
            iScaryClownReference.ScareAdults();
        }
    }
}
