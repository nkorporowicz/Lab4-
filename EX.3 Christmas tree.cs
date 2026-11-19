Console.WriteLine("Choose a number from 2 to 10");
int height = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= height - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = 1; i <= height - 1; i++)
{
    Console.Write(" ");
}

Console.WriteLine("*");