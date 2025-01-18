
namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while(true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide bt");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }

            Console.WriteLine("Hello, World!");
        }
        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse.</returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]: ");
            string value = Console.ReadLine();
            if(int.TryParse(value, out int newValue))
            {
                Console.WriteLine("    using value " + newValue);
                return newValue;
            }
            Console.WriteLine("    using default value " + lastUsedValue);
            return lastUsedValue;
        }
        /// <summary>
        /// Writes a prompt and reads an double value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns>The double value read, or the default value if unable to parse.</returns>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]: ");
            string value = Console.ReadLine();
            if (double.TryParse(value, out double newValue))
            {
                Console.WriteLine("    using value " + newValue);
                return newValue;
            }
            Console.WriteLine("    using default value " + lastUsedValue);
            return lastUsedValue;
        }
    }
}
