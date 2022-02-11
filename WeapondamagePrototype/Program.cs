using System;

namespace WeaponDamagePrototype
{
    internal class Program
    {
       static Random random = new Random();
        static void Main(string[] args)
        {
            //Instances 
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

            //Game loop
            while(true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, or anything to quit:  ");
                char key = Console.ReadKey().KeyChar;
                if (key != 0 && key != 1 && key != 2 && key != 3) return;

                Console.WriteLine("\nS for sword, A for arrow, or anything else to quit:  ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (key == '1' || key == '3');
                        swordDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"Rolled {swordDamage.Roll} for {swordDamage.Damage} damage!\n");
                        break;
                    case 'A':
                        arrowDamage.Roll = RollDice(3);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"Rolled {arrowDamage.Roll} for {arrowDamage.Damage} damage!\n");
                        break;
                    default:
                        return;
                }
            }
        }
        //Helper methods
        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numberOfRolls; i++) total += random.Next(1, 7);
            return total;
        }
    }
}
