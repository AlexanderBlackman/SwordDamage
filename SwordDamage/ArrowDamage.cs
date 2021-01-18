using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DamageCalculator
{
    class ArrowDamage: Damage
    {
        private const decimal BASE_MULTIPLIER = 0.35m;
        private const decimal MAGIC_MULTIPLIER = 2.5m;
        private const decimal FLAME_DAMAGE = 1.25m;

        //is this right? There's only 1d6 being rolled.
        public ArrowDamage(int startingRoll) : base(startingRoll) { }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) TotalDamage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else TotalDamage = (int)Math.Ceiling(baseDamage);

        }

    }

    class BladeDamage: Damage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public BladeDamage(int startingRoll) : base(startingRoll) { }

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            //if(something)  is short for if (something == true)
            if (Magic) magicMultiplier = 1.75M;

            TotalDamage = BASE_DAMAGE;
            TotalDamage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming) TotalDamage = FLAME_DAMAGE;
            Debug.WriteLine($"CalculateDamage finished: {TotalDamage}(roll: {Roll})");

        }
    }
}
