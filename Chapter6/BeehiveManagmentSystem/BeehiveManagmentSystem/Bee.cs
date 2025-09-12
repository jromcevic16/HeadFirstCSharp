using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeehiveManagmentSystem
{
    public abstract class Bee
    {
        public readonly string job;
        public abstract float CostPerShift { get; }
        public Bee(string job)
        {
            this.job = job;
        }
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }
        protected abstract void DoJob();
    }
}
