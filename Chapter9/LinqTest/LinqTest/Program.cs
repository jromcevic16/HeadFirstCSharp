using System.Linq;
using System.Collections.Generic;

namespace LinqTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++)
            {
                numbers.Add(i);
            }
            IEnumerable<int> firstAndLatFive = numbers.Take(5).Concat(numbers.TakeLast(5));
            foreach(int i in firstAndLatFive)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
