int countPackDogFood = int.Parse(Console.ReadLine());
int countPackCatFood = int.Parse(Console.ReadLine());
double expDogFood = countPackDogFood * 2.50;
double expCatFood = countPackCatFood * 4;
double expTotal = expDogFood + expCatFood;
Console.WriteLine($"{expTotal:f2} lv.");
