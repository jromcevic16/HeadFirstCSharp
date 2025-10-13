namespace Swindler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by the Swindler");
            sw.WriteLine("I'll unleash my army of clones upon the citizens of Objectville.");

            string location = "the mall";
            for (int i = 1; i <= 5; i++)
            {
                sw.WriteLine("Clone #{0} attacks {1}",i,location);
                location = (location == "the mall") ? "downtown" : "the mall";
            }
            sw.Close();
        }
    }
}
