namespace ImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue;
            Console.WriteLine("myIntValue is "+myIntValue);

            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            bool myBool = (bool)myDouble;
            string myString = "false";
            myBool = (bool)myString;
            myString = (string)myInt;
            myString = myInt.ToString();
            myBool = (bool)myByte;
            myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;

            long number = 139582038;
            string text = "player score: " + number;
            text = number;
            myInt = random.Next(1.0, 5);
            MyMethod(myInt);
        }
        public int MyMethod(bool add3)
        {
            int value = 12;
            if (add3)
                value += 3;
            else
                value -= 2;
            return value;
        }
    }
}
