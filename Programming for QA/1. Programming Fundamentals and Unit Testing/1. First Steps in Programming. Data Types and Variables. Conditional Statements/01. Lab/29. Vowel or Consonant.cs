namespace _07._Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string letter = Console.ReadLine();

            if(letter == "a" || letter == "A" || letter == "e" || letter == "E" || letter == "i" || letter == "I" || letter == "o" || letter == "O" || letter == "u" || letter == "U")
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            

        }
    }
}