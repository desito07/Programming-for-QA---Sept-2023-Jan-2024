namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());

            double costStudio = 0.00;
            double costApartment = 0.00;

            if (month == "May" || month == "October")
            {
                costStudio = 50 * countNights;
                costApartment = 65 * countNights;
                if (countNights > 7 && countNights <= 14)
                {
                    costStudio -= costStudio * 0.05;
                }
                else if (countNights > 14)
                {
                    costStudio -= costStudio * 0.3;
                    costApartment -= costApartment * 0.1;
                }
                
            }
            else if (month == "June" || month == "September")
            {
                costStudio = 75.20 * countNights;
                costApartment = 68.70 * countNights;
                if (countNights > 14)
                {
                    costStudio -= costStudio * 0.2;
                    costApartment -= costApartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                costStudio = 76 * countNights;
                costApartment = 77 * countNights;
                if (countNights > 14)
                {
                    costApartment -= costApartment * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {costApartment:f2} lv.");
            Console.WriteLine($"Studio: {costStudio:f2} lv.");
  
        }
    }
}
