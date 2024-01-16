
double firstNum = double.Parse(Console.ReadLine());
double secondNum =  double.Parse(Console.ReadLine());
double sumPlus = firstNum + secondNum;
double sumMinus = firstNum - secondNum;
double sumMultiplication = firstNum * secondNum;
double sumDivision = firstNum / secondNum;

Console.WriteLine($"{firstNum:f2} + {secondNum:f2} = {sumPlus:f2}");
Console.WriteLine($"{firstNum:f2} - {secondNum:f2} = {sumMinus:f2}");
Console.WriteLine($"{firstNum:f2} * {secondNum:f2} = {sumMultiplication:f2}");
Console.WriteLine($"{firstNum:f2} / {secondNum:f2} = {sumDivision:f2}");


