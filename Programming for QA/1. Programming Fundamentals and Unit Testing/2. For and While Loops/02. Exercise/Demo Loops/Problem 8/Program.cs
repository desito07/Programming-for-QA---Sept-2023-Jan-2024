string command = Console.ReadLine();
double balance = 0.00;

while(command != "End")
{
    double num = double.Parse(command);
    if(num >= 0)
    {
         Console.WriteLine($"Increase: {num:f2}");
        balance += num;
    }
    
    if (num < 0)
    {
        Console.WriteLine($"Decrease: {Math.Abs(num):f2}");
        balance += num;
    }
    
    command = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:f2}");