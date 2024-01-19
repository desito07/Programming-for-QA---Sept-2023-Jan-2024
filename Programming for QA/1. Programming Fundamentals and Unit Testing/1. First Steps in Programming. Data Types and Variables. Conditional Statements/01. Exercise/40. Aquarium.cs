int lengthCm = int.Parse(Console.ReadLine());
int widthCm =  int.Parse(Console.ReadLine());
int heightCm =  int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volume = lengthCm * widthCm * heightCm;
double volumeLiters = volume / 1000;
double requiredLiters = volumeLiters * (1 - (percentage / 100));

Console.WriteLine($"{requiredLiters:f2}");