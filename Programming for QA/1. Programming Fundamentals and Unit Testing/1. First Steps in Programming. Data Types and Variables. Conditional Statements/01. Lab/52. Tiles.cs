using System.Transactions;

double bathWidth = double.Parse(Console.ReadLine());
double bathHeight = double.Parse(Console.ReadLine());
double tileWidth  = double.Parse(Console.ReadLine());
double tileHeight  = double.Parse(Console.ReadLine());

double bathArea = bathWidth * bathHeight; 
double tileArea = tileWidth * tileHeight;
double bathAreaSurplus = bathArea * 0.1 + bathArea;
double total = bathAreaSurplus / tileArea;
Console.WriteLine($"{Math.Round(total)}");