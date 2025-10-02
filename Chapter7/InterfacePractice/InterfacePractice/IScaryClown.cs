using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
        void ScareAdults()
        {
            Console.WriteLine($@"I am an ancient evil that will hunt your dreamns.
behold my terifying necklace with {random.Next(4, 10)} of my last victim's fingers.

Oh, also, beforei forget...");
            ScareLittleChildren();
        }
    }
}
