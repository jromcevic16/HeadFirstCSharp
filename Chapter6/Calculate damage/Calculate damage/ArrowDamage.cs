using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_damage
{
    public class ArrowDamage : WeponeDamage
    {
        public decimal BASE_MULTIPLIER = 0.35M;
        public decimal MAGIC_MULTIPLIER = 2.5M;
        public decimal FLAME_DAMAGE = 1.25M;
        public ArrowDamage(int roll) : base(roll)
        {
        }
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (magic) baseDamage *= MAGIC_MULTIPLIER;
            if (flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
