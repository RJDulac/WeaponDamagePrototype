using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamagePrototype
{
    internal class ArrowDamage
    {
        //fields
        private const decimal BASE_MULTIPLIER = 0.35m;
        private const decimal FLAME_MULTIPLIER = 2.5m;
        private const decimal FLAME_DAMAGE = 1.25m;

        private int roll;
        private bool flamming;
        private bool magic;

        //Properties
        /// <summary>
        /// Sets or gets the dice roll.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// True if the sword is flaming, false if it's not.
        /// </summary>
        public bool Flaming
        {
            get { return flamming; }
            set
            {
                flamming = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// True if the sword is magic, false if it's not.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Contains the calculated damage.
        /// </summary>
        public int Damage { get; private set; }

        //constructor
        /// <summary>
        /// The constructor calculates damage based on default magic and flaming values and the starting roll.
        /// </summary>
        /// <param name="startRolling"></param>
        public ArrowDamage(int startRolling)
        {
            roll = startRolling;
            CalculateDamage();

        }

        //methods
        /// <summary>
        /// Calculates damage based on current properties.
        /// </summary>
        public void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;


            if (magic) { baseDamage *= BASE_MULTIPLIER; }

            if (flamming) { Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE); }
            else { Damage = (int)Math.Ceiling(baseDamage); }
        }

    }
}
