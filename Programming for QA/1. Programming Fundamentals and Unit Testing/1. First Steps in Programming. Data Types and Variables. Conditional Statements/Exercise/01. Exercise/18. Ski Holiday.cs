namespace _09._Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            double cost = 0.00;

            if(typeOfRoom == "room for one person")
            {
                cost = (daysToStay - 1) * 118;
            }
            else if(typeOfRoom == "apartment")
            {
                cost = (daysToStay - 1) * 155;
                if (daysToStay < 10)
                {
                    cost -= cost * 0.3;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    cost -= cost * 0.35;
                }
                else if(daysToStay > 15)
                {
                    cost -= cost * 0.5;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                cost = (daysToStay - 1) * 235;
                if (daysToStay < 10)
                {
                    cost -= cost * 0.1;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    cost -= cost * 0.15;
                }
                else if (daysToStay > 15)
                {
                    cost -= cost * 0.2;
                }
            }
            if(assessment == "positive")
            {
                cost += cost * 0.25;
            }
            else
            {
                cost -= cost * 0.1;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}
