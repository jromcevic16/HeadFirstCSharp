using System;

namespace Calculate_damage
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            char weaponKey;
            char key;
            while (true)
            {
                Console.WriteLine("\nS for sword, A for arrow, anything else to quit: ");
                weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, aythingelse to quit:");
                        key = Console.ReadKey(false).KeyChar;
                        if (key != '1' && key != '2' && key != '3' && key != '0') return;

                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = key == '1' || key == '3';
                        swordDamage.Flaming = key == '2' || key == '3';
                        Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP");
                        break;
                    case 'A':
                        Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, aythingelse to quit:");
                        key = Console.ReadKey(false).KeyChar;
                        if (key != '1' && key != '2' && key != '3' && key != '0') return;

                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = key == '1' || key == '3';
                        arrowDamage.Flaming = key == '2' || key == '3';
                        Console.WriteLine("\nRolled " + arrowDamage.Roll + " for " + arrowDamage.Damage + " HP");
                        break;
                    default:
                        return;
                }


            }
        }

        public static int RollDice(int numberOfRolls)
        {
            int roll = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                roll += random.Next(1, 7);
            }
            return roll;
        }
    }
}
