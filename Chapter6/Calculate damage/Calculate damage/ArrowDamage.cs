using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_damage
{
    public class ArrowDamage
    {
        public const decimal BASE_MULTIPLIER = 0.35M;
        public const decimal MAGIC_MULTIPLIER = 2.5M;
        public const decimal FLAME_DAMAGE = 1.25M;
        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public int Damage { get; private set; }
        public ArrowDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (magic) baseDamage *= MAGIC_MULTIPLIER;
            if (flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
