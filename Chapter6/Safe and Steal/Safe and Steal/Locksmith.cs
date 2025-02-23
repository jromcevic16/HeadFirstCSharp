using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_and_Steal
{
    internal class Locksmith
    {
        public string Combination { private get; set; }
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }
        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
