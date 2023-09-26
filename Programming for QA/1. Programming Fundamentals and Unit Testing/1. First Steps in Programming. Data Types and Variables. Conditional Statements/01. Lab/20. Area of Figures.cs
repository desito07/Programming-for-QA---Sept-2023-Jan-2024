namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.00;


            if (figure == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                area = num1 * num1;
                Console.WriteLine($"{area:f2}");
            }
            else if (figure == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                area = num1 * num2;
                Console.WriteLine($"{area:f2}");
            }
            else if (figure == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                area = Math.PI * num1 * num1;
                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
            
        }
    }
}