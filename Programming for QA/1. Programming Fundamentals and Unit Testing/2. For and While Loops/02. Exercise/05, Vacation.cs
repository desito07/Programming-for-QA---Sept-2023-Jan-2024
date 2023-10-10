namespace _05. Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            int counterSpending = 0;


            while (counterSpending < 5)
            {

                if (moneyAvailable >= moneyNeeded)
                {
                    break;
                }
                counter++;
                int currentMoney = int.Parse(Console.ReadLine());

                if (command == "spend")
                {
                    moneyAvailable -= currentMoney;
                    counterSpending++;
                }
                if (command == "save")
                {
                    moneyAvailable += currentMoney;
                    counterSpending = 0;
                }
                if (moneyAvailable < 0)
                {
                    moneyAvailable = 0;
                }

                command = Console.ReadLine();
            }
            if (moneyAvailable >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{counter}");
            }
        }
    }
}
