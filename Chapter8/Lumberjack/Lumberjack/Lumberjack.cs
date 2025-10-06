using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjack
{
    internal class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public Lumberjack(string name)
        {
            Name = name;
        }
        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }
        public void EatFlapjack()
        {
            Console.WriteLine($"{Name} ate a {flapjackStack.Pop()} flapjack");
        }
        public void EatAllFlapjacks()
        {
            while(flapjackStack.Count > 0)
            {
                EatFlapjack();
            }
        }
    }
}
