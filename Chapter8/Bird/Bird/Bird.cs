using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    internal class Bird
    {
        public string Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} is flaying to {destination}");
        }
        public override string ToString()
        {
            return $"A bird named {Name}";
        }
        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach(Bird b in flock)
            {
                b.Fly(destination);
            }
        }
    }
}
