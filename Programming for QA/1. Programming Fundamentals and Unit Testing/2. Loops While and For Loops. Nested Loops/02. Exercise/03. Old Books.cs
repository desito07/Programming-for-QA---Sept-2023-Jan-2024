namespace _03._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string command = Console.ReadLine();
            int counter = 0;
            bool isFound = false;

            while(command != "No More Books")
            {
                
                if (command == book)
                {
                    isFound = true;
                    break;
                }
                counter++;
                command = Console.ReadLine();
            }
            if(isFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            
        }
    }
}