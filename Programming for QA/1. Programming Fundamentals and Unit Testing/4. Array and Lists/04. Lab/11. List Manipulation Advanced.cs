using System;

List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    //Console.WriteLine(commandName);

   if(commandName == "Contains")
   {
        int containedNum = int.Parse(commandParts[1]);
        if (numbers.Contains(containedNum))
        {
            Console.WriteLine("Yes");
        }
        else 
        {
            Console.WriteLine("No such number");
        }
    }
   if(commandName == "PrintEven")
    {

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    if (commandName == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    if (commandName == "GetSum")
    {
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }
   if(commandName == "Filter")
    {
        string condition = commandParts[1];
        int num = int.Parse(commandParts[2]);
        if(condition == "<")
        {
            numbers.RemoveAll(x => x >= num);
        }
        else if(condition == ">")
        {
            numbers.RemoveAll(x => x <= num);
        }
        else if (condition == "<=")
        {
            numbers.RemoveAll(x => x > num);
        }
        else if (condition == ">=")
        {
            numbers.RemoveAll(x => x < num);
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));