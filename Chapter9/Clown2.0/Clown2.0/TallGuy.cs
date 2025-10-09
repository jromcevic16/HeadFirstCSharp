using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown2._0
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave => "big red shous";

        public void Honk() => Console.WriteLine("Honk honk!");

        public void TalkAboutYourself() 
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");    
        }
    }
}
