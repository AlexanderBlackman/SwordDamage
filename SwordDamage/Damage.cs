using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DamageCalculator
{
    public class Damage
    {
        #region Properties, consts and Variables

        // WHERE IS ROLL SET???
        private int roll;
        public int Roll {
            get { return roll; }
            set {
                roll = value;
                CalculateDamage();
            }
        }

        public int TotalDamage { get; protected set; }
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
        #endregion

        /// <summary>
        /// Calculates Damage based on the current state.
        /// </summary>
        protected virtual void CalculateDamage()
        {
        /*    decimal magicMultiplier = 1M;
            //if(something)  is short for if (something == true)
            if (magic) magicMultiplier = 1.75M;

            TotalDamage = BASE_DAMAGE;
            TotalDamage = (int)(Roll * magicMultiplier) + BASE_DAMAGE; 
            
            if(flaming) TotalDamage += FLAME_DAMAGE;
            Debug.WriteLine($"CalculateDamage finished: {TotalDamage}(roll: {Roll})");
        */
        }
        /// <summary>
        /// The constructor calculates damage based on an initial roll, 
        /// and default (false) values for flaming/magic
        /// </summary>
        /// <param name="startingRoll"></param>
        public  Damage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

    }
 /*   public int RollDice(int noOfDice, int noOfSides = 6)
    {
        int total = 0;
        Random dice = new Random();
        for (int i = 0; i <= noOfDice; i++)
        {
            total += dice.Next(1, noOfSides);
        }
        return total;

    }*/
}
    

        



    

