using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Funnyfunny : IClown
    {
        private readonly string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }
        public Funnyfunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}.");
        }
    }
}
