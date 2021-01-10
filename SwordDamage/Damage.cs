using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SwordDamage
{
    public class Damage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1m;
        public int FlamingDamage = 0;
        public int TotalDamage;



        public void CalculateDamage()
        {

            TotalDamage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"CalculateDamage finished: {TotalDamage}(roll: {Roll})");
            
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
                MagicMultiplier = 1.75m;
            else
                MagicMultiplier = 1m;
            CalculateDamage();
        }
        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
                TotalDamage += FLAME_DAMAGE;

        }
        public int RollDice(int noOfDice, int noOfSides = 6)
        {
            int total = 0;
            Random dice = new Random();
            for (int i = 0; i <= noOfDice; i++)
            {
                total += dice.Next(1, noOfSides);
            }
            return total;

        }

    }
}
        



    

