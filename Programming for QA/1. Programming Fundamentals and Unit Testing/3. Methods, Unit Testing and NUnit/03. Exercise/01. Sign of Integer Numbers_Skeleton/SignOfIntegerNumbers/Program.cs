namespace SignOfIntegerNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(SignIdentifier.SignOfInteger(number));
        }       
    }
}