using System.Reflection;

namespace HasASicret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasASicret keeper = new HasASicret();
            FieldInfo[] fileds = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in fileds)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
}
