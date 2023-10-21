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

    int num = int.Parse(commandParts[1]);
    
    if (commandName == "Add")
    {
        numbers.Add(num);
    }
    else if (commandName == "Remove")
    {
        numbers.Remove(num);
    }
    else if (commandName == "RemoveAt")
    {
        numbers.RemoveAt(num);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, num);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));