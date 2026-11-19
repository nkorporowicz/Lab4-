int turns = 0;

while (true)
{
    Console.WriteLine("Tell the number of rounds from 1 to 10:");
    string input = Console.ReadLine()!;

    if (!int.TryParse(input, out turns))
    {
        Console.WriteLine("Write an integer.");
        continue;
    }

    if (turns < 1)
    {
        Console.WriteLine("Number has to be in range from 1 to 10.");
        continue;
    }

    if (turns > 10)
    {
        Console.WriteLine("Number has to be in range from 1 to 10.");
        continue;
    }

    break;
}

Console.WriteLine("Starting game for " + turns + " rounds.");