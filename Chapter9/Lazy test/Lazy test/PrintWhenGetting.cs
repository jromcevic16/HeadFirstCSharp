using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_test
{
    internal class PrintWhenGetting
    {
        private int instaceNumber;
        public int InstanceNumber
        {
            set { instaceNumber = value; }
            get
            {
                Console.WriteLine($"Getting #{instaceNumber}");
                return instaceNumber;
            }
        }
    }
}
