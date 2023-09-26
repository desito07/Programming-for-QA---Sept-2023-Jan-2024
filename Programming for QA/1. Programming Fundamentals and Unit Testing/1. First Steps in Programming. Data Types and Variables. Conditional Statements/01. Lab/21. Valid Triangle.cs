using System;

namespace Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());

            bool isValidTriangle = true;

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                isValidTriangle = false;
                Console.WriteLine("Invalid Triangle");
            }
            else
            {
                isValidTriangle = true;
                Console.WriteLine("Valid Triangle");
            }
        }
    }
}