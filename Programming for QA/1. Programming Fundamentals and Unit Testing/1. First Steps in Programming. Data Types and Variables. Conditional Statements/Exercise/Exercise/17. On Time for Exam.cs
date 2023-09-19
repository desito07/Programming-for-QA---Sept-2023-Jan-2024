namespace _18._On Time for Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExamStart = int.Parse(Console.ReadLine());
            int minExamStart = int.Parse(Console.ReadLine());
            int hourArival = int.Parse(Console.ReadLine());
            int minArival = int.Parse(Console.ReadLine());

            int minExamStartTotal = hourExamStart * 60 + minExamStart;
            int minArivalTotal = hourArival * 60 + minArival;

            if (minArivalTotal > minExamStartTotal)
            {
                Console.WriteLine("Late");
                int minDifference = minArivalTotal - minExamStartTotal;
                if (minDifference <= 60)
                {
                    Console.WriteLine($"{minDifference} minutes after the start");
                }
                else
                {
                    int hours = minDifference / 60;
                    int min = minDifference % 60;
                    Console.WriteLine($"{hours}:{min:d2} hours after the start");
                }
            }
            else if (minArivalTotal < minExamStartTotal - 30)
            {
                Console.WriteLine("Early");
                int minDifference = minExamStartTotal - minArivalTotal;
                if (minDifference < 60)
                {
                    Console.WriteLine($"{minDifference} minutes before the start");
                }
                else
                {
                    int hours = minDifference / 60;
                    int min = minDifference % 60;
                    Console.WriteLine($"{hours}:{min:d2} hours before the start");
                }
            }
            else
            {
                int minDiff = minExamStartTotal - minArivalTotal;
                Console.WriteLine("On time");
                if (minDiff != 0)
                {
                    Console.WriteLine($"{minDiff} minutes before the start");
                }
            }
        }
    }
}
