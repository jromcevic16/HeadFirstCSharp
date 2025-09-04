using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_damage
{
    public class SwordDamage : WeponeDamage
    {
        public int BASE_DAMAGE = 3;
        public int FLAME_DAMAGE = 2;
        public SwordDamage(int roll) : base(roll)
        {
        }
        protected override void CalculateDamage()
        {
        
            decimal magicMultiplier = 1M;
            if (magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (flaming) Damage += FLAME_DAMAGE;
        }
    }
}
