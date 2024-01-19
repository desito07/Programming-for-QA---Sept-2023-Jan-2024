int annualFee = int.Parse(Console.ReadLine());

double sneakers = annualFee - (annualFee * 0.4);
double team = sneakers - (sneakers * 0.2);
double basketball = team * 0.25;
double accessories = basketball * 0.2;

double cost = annualFee + sneakers + team + basketball + accessories;
Console.WriteLine(cost);