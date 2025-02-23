using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_and_Steal
{
    internal class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContetns)
        {
            valuables = safeContetns;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
