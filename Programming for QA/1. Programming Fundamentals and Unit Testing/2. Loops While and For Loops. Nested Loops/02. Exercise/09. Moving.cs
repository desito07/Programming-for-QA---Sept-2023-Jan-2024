namespace _09._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int count = width * height * depth;
            string command = Console.ReadLine();

            while (command != "Done")
            {

                int freeSpace = int.Parse(command);
                if (command == "Done")
                {
                   
                    break;
                }

                if (freeSpace > count)
                {
                    Console.WriteLine($"No more free space! You need {freeSpace - count} Cubic meters more.");
                    break;
                }

                count -= freeSpace;

                if (count < 0)
                {
                    break;
                }
                command = Console.ReadLine();

            }
            if(command == "Done")
            {
                Console.WriteLine($"{count} Cubic meters left.");
            }
            
        }
    }
}
