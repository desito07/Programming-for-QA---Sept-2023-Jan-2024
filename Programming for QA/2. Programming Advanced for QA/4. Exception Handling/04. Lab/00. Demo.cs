string s = Console.ReadLine();

try
{
    int.Parse(s);
    Console.WriteLine("You entered a valid Int32 number {0}.", s);
}
catch(FormatException) {
    Console.WriteLine("Invalid integer number!"); 
}
catch (OverflowException)
{
    Console.WriteLine("The number is too bog to fit in Int32!");
}