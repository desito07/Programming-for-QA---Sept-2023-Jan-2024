namespace _09._The_Smallest_Number
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string command = (Console.ReadLine());
                int minNumber = int.MaxValue;

                while (command != "Stop")
                {
                    int currentNum = int.Parse(command);

                    if (currentNum < minNumber)
                    {
                        minNumber = currentNum;
                    }
                    command = (Console.ReadLine());
                }
                Console.WriteLine(minNumber);
            }
       
    }
}
