namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operatorS = Console.ReadLine();
            int result = 0;

            if(operatorS == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - odd");
                }
            }
            else if(operatorS == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - odd");
                }
            }
            else if (operatorS == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result} - odd");
                }
            }
            else if(operatorS == "/")
            {
                if (num2  == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result:f2}");
                }
            }
            else if (operatorS == "%")
            {
                 if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {operatorS} {num2} = {result}");
                }
            }
        }


    }
}