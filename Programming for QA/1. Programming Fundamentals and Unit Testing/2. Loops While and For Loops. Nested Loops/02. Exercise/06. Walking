namespace _06._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plannedSteps = 10000;
            int actualSteps = 0;
            string command = Console.ReadLine();

            while (actualSteps <= plannedSteps)
            {

                if (command == "Going home")
                {
                    actualSteps += int.Parse(Console.ReadLine());
                    break;
                }
                int currentSteps = int.Parse(command);
                actualSteps += currentSteps;
                command = Console.ReadLine();
            }
            if(actualSteps >= plannedSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{actualSteps - plannedSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{plannedSteps - actualSteps} more steps to reach goal.");
            }
        }
    }
}
