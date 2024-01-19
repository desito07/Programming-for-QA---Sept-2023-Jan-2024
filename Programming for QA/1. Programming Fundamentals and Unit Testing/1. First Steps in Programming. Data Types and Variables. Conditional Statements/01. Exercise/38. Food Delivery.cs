int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegs =  int.Parse(Console.ReadLine());

double chickenPrice = chicken * 10.35;
double fishPrice = fish * 12.40;
double vegsPrice = vegs * 8.15;
double cost = chickenPrice + fishPrice + vegsPrice;
double dessertPrice = cost * 0.2;
double deliveryPrice = 2.5;
double total = cost + dessertPrice + deliveryPrice;
Console.WriteLine(total);