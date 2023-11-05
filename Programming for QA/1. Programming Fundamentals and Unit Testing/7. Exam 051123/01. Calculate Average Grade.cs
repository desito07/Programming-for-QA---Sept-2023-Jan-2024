
using System.Data;

int n = int.Parse(Console.ReadLine());
double sum = 0.0;

for(int i = 0; i < n; i++)
{
    double current  = double.Parse(Console.ReadLine());
    sum += current;
} 

double avr = sum / n;
Console.WriteLine($"{avr:f2}");



