namespace _15._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalStudentTickets = 0;
            int totalKidsTickets = 0;
            int totalStandardTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }
                int movieSize = int.Parse(Console.ReadLine());
                int moviesSoldTickets = 0;

                while (moviesSoldTickets < movieSize)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else
                    {
                        moviesSoldTickets++;
                        switch (ticketType)
                        {
                            case "kid": totalKidsTickets++; break;
                            case "student": totalStudentTickets++; break;
                            case "standard": totalStandardTickets++; break;
                        }
                    }
                }
                Console.WriteLine($"{movieName} - {moviesSoldTickets * 100.0 / movieSize:f2}% full.");
            }
            int totalTickets = totalKidsTickets + totalStudentTickets + totalStandardTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{totalStandardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{totalKidsTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}
