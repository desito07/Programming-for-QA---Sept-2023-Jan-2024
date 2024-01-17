int packOfPens = int.Parse(Console.ReadLine());
int packOfMarkers =  int.Parse(Console.ReadLine());
int packOfBoardCleaners =  int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double pricePens = packOfPens * 5.80;
double priceMarkers = packOfMarkers * 7.20;
double priceBoardCleaners = packOfBoardCleaners * 1.20;
double totalExpenses = pricePens + priceMarkers + priceBoardCleaners;
double discounted = percentage / 100;
double discount = totalExpenses * (percentage / 100);
double discountedTotal = totalExpenses - discount;
Console.WriteLine($"{discountedTotal:f2}");

