namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accommodation = "";
            double cost = 0.00;

            if(season == "summer")
            {
                if(budget <= 100)
                {
                    cost = budget * 0.3;
                    destination = "Bulgaria";
                    accommodation = "Camp";
                }
                else if(budget > 100 && budget <= 1000)
                {
                    cost = budget * 0.4;
                    destination = "Balkans";
                    accommodation = "Camp";
                }
                else if (budget > 1000)
                {
                    cost = budget * 0.9;
                    destination = "Europe";
                    accommodation = "Camp";
                }
            }
            else if(season == "winter")
            {

                if (budget <= 100)
                {
                    cost = budget * 0.7;
                    destination = "Bulgaria";
                    accommodation = "Hotel";
                }
                else if (budget > 100 && budget <= 1000)
                {
                    cost = budget * 0.8;
                    destination = "Balkans";
                    accommodation = "Hotel";
                }
                else if (budget > 1000)
                {
                    cost = budget * 0.9;
                    destination = "Europe";
                    accommodation = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {cost:f2}");
        }
    }
}