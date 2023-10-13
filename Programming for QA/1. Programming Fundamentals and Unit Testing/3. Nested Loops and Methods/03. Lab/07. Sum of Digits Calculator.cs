using System.Diagnostics.Metrics;

namespace _07._Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while (command != "End")
            {
                int currentNum = int.Parse(command);
                int sum = 0;
                for (int i = currentNum; i > 0; i/= 10) 
                {
                    int result = i % 10;
                    sum += result;
                    
                }
                Console.WriteLine($"Sum of digits = {sum}");
                command = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}