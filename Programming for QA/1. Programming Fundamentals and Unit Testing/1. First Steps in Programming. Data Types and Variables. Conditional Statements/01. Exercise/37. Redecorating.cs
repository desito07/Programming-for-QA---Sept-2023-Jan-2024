int nylon = int.Parse(Console.ReadLine());
int paint =  int.Parse(Console.ReadLine());
int tinner  = int.Parse(Console.ReadLine());
int hoursNeeded =  int.Parse(Console.ReadLine());

double nylonAmount = (nylon + 2) * 1.50;
double paintAmount = ((paint + (paint * 0.10)) * 14.50);
double tinnerAmount = tinner * 5;
double bags = 0.40;
double totalMaterials = nylonAmount + paintAmount + tinnerAmount + bags;
double labour = (totalMaterials * 0.30) * hoursNeeded;
double total = totalMaterials +  labour;

Console.WriteLine(total);
