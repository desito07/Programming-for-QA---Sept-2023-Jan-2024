namespace _23._Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodation = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            
            double cost = 0.0;
            
            if(season == "Spring")
            {
                if(accommodation == "Hotel")
                {
                    cost = nights * 30; 
                }
                else if(accommodation == "Camping")
                {
                    cost = nights * 10;
                }
                cost -= cost * 0.2;
            }
            else if(season == "Summer")
            {
                if (accommodation == "Hotel")
                {
                    cost = nights * 50;
                }
                else if (accommodation == "Camping")
                {
                    cost = nights * 30;
                }
             }
            else if (season == "Autumn")
            {
                if (accommodation == "Hotel")
                {
                    cost = nights * 20;
                }
                else if (accommodation == "Camping")
                {
                    cost = nights * 15;
                }
                cost -= cost * 0.3;
            }
            else if(season == "Winter")
            {
                if (accommodation == "Hotel")
                {
                    cost = nights * 40;
                }
                else if (accommodation == "Camping")
                {
                    cost = nights * 10;
                }
                cost -= cost * 0.1;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}