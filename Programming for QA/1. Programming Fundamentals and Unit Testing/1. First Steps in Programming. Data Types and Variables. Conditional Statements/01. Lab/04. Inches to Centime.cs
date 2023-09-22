namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double inputInches = (input * 2.54);
            Console.WriteLine(inputInches);

        }
    }
}