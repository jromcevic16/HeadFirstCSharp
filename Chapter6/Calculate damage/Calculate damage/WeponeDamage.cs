using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_damage
{
    public abstract class WeponeDamage
    {

        protected int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        protected bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        protected bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public int Damage { get; protected set; }
        public WeponeDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
        protected abstract void CalculateDamage();
    }
}
