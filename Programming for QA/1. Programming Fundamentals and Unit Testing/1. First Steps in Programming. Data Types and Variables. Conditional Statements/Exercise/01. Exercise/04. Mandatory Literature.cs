namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalReadingTime = numPages / pagesPerHour;
            int hoursRequired = totalReadingTime / days;
            Console.WriteLine(hoursRequired);
        }
    }
}
