namespace _11._Animal_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            if (input == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (input == "crocodile" || input == "tortoise" || input == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}