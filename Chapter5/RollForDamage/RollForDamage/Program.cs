namespace RollForDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage(SwordDamage.RollDice());
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, aythingelse to quit:");
                char key = Console.ReadKey(false).KeyChar;
                if (key != '1' && key != '2' && key != '3' && key != '0') return;

                swordDamage.Roll = SwordDamage.RollDice();
                swordDamage.Magic = key == '1' || key == '3';
                swordDamage.Flaming = key == '2' || key == '3';
                Console.WriteLine("\nRolled "+swordDamage.Roll+" for "+swordDamage.Damage+" HP");

            }
        }
    }
}
