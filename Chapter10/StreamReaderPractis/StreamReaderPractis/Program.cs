namespace StreamReaderPractis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var reader = new StreamReader($"{folder}{Path.DirectorySeparatorChar}secret_plan.txt");
            var writer = new StreamWriter($"{folder}{Path.DirectorySeparatorChar}emailToCaptainA.txt");

            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindeler's terrible plan:");

            while(!reader.EndOfStream)
            {
                var lineFromThePLan = reader.ReadLine();
                writer.WriteLine($"The plan -> {lineFromThePLan}");
            }
            writer.WriteLine();
            writer.WriteLine("Can you healp us?");

            writer.Close();
            reader.Close();
        }
    }
}
