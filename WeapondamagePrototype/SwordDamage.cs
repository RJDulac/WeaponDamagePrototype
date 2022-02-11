using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WeaponDamagePrototype
{
    internal class SwordDamage
    {
        //fields
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

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
        public SwordDamage(int startRolling)
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
            decimal MagicMultipler = 1m;

            Damage = BASE_DAMAGE;


            if (magic) { MagicMultipler = 1.75m; }
        
            Damage = (int)(Roll * MagicMultipler) + BASE_DAMAGE;

            if (flamming) { Damage += FLAME_DAMAGE; }
        }

    }
}
