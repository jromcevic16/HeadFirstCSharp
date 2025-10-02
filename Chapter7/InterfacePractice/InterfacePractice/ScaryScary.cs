using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class ScaryScary : Funnyfunny, IScaryClown
    {
        int scaryThingCount;
        public string ScaryThingIHave
        {
            get
            {
                return $"{scaryThingCount} spiders";
            }
        }
        public ScaryScary(string funnyThingIHave, int scaryThingCount) : base(funnyThingIHave)
        {
            this.scaryThingCount = scaryThingCount;
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }
    }
}
