namespace _22._Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operatorN = Console.ReadLine();
            double result = 0.0;

            if(operatorN == "+")
            {
                result = n1 + n2;
            }
            else if(operatorN == "-")
            {
                result = n1 - n2;
            }
            else if (operatorN == "*")
            {
                result = n1 * n2;
            }
            else if( operatorN == "/")
            {
                result = n1 / n2;
            }
            Console.WriteLine($"{n1} {operatorN} {n2} = {result:f2}");

        }
    }
}