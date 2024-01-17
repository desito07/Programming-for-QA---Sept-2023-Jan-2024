int numPages = int.Parse(Console.ReadLine());
int pagesInHour = int.Parse(Console.ReadLine());
int numDays = int.Parse(Console.ReadLine());

int totalReadingTime = (numPages / pagesInHour);
int requiredHoursPerDay = (totalReadingTime / numDays);
Console.WriteLine(requiredHoursPerDay);