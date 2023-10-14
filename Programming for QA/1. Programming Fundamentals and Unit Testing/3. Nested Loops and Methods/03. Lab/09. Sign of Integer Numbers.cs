static void PrintNumberSign(int num)
{
    if (num == 0)
    {
        Console.WriteLine($"The number {num} is zero.");
    }
    else if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {num} is negative.");
    }

}
int num = int.Parse(Console.ReadLine());
PrintNumberSign(num);
