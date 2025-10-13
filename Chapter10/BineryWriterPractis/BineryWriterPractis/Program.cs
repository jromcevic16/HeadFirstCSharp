using System.IO;
namespace BineryWriterPractis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695f;
            char charBalue = 'E';

            using (var output = File.Create("binarydata.dat"))
            using (var writer = new BinaryWriter(output))
            {
                writer.Write(intValue );
                writer.Write(stringValue );
                writer.Write(byteArray);
                writer.Write(floatValue );
                writer.Write(charBalue);
            }
            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
            foreach (var data in dataWritten)
            {
                Console.Write("{0:x2}", data);
            }
            Console.WriteLine(" - {0} byres",dataWritten.Length);

            using (var input = File.OpenRead("binarydata.dat"))
            using (var reader = new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string stringRead = reader.ReadString();
                byte[] byteArrayRead = reader.ReadBytes(4);
                float floatRead = reader.ReadSingle();
                char charRead = reader.ReadChar();
                Console.Write("int: {0}  string: {1}  bytes: " + String.Join(" ",byteArrayRead) +" TEST", intRead, stringRead);
                foreach(byte b in byteArrayRead)
                {
                    Console.Write("{0} ", b);
                }
                Console.Write(" float: {0}  char: {1} ", floatRead, charRead);
            }
        }
    }
}
