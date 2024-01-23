string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double result = CalculateTotalPrice(product, quantity);
Console.WriteLine($"{result:f2}");

static double CalculateTotalPrice(string product, int quantity)
{
    double result = 0.00;

    if (product == "coffee")
    {
        result = quantity * 1.50;
    }
    else if (product == "water")
    {
        result = quantity * 1.00;
    }
    else if (product == "coke")
    {
        result = quantity * 1.40;
    }
    else if (product == "snacks")
    {
        result = quantity * 2.00;
    }
    return result;
}