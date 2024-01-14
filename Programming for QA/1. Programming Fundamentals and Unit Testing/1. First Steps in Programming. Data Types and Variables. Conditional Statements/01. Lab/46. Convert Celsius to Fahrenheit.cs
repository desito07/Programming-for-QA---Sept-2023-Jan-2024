double temperatureInC = double.Parse(Console.ReadLine());
double temperatureInF = temperatureInC * 1.8 + 32;
Console.WriteLine($"{temperatureInF:f2}");