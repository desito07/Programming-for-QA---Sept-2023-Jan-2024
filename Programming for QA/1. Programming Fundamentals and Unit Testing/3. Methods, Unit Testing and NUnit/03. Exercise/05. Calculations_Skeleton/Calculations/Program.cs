namespace Calculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = 0;

            if (command == "add")
            {
                result = Calculator.Add(firstNumber, secondNumber);
            }

            if (command == "multiply")
            {
                result = Calculator.Multiply(firstNumber, secondNumber);
            }

            if(command == "subtract")
            {
                result = Calculator.Subtract(firstNumber, secondNumber);
            }

            if (command == "divide")
            {
                result = Calculator.Divide(firstNumber, secondNumber);
            }

            Console.WriteLine(result);
        }
    }
}