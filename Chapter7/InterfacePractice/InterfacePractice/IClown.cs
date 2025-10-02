using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal interface IClown
    {
        protected static Random random = new Random();
        private static int carCapacity = 12;
        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Warning: Car capacity {value} is to small");
            }
        }
        public static string ClownCarDescriptio()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }
        string FunnyThingIHave {  get; }
        void Honk();
    }
}
