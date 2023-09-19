namespace _08._The_Greatest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = (Console.ReadLine());
            int maxNumber = int.MinValue;

            while(command != "Stop")
            {
                int currentNum = int.Parse(command);

                if(currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
                command = (Console.ReadLine());
            }
            Console.WriteLine(maxNumber);
        }
    }
}