int stopNumber = int.Parse(Console.ReadLine());
double previousNumber = 0.0;

while (true)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if(currentNumber == stopNumber)
    {
        previousNumber += previousNumber * 0.2;
        Console.WriteLine(previousNumber);
        break;
    }
    previousNumber = currentNumber;
}