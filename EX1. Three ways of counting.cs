int number_1 = 1;
Console.WriteLine("Numbers from while loop");

while (number_1 <= 10)
{
    Console.Write(number_1 + " ");
    number_1++;
}
Console.WriteLine("\n--------------------------------");

int number_2 = 1;
Console.WriteLine("Numbers from do-while loop");

do
{
    Console.Write(number_2 + " ");
    number_2++;
}
while (number_2 <= 10);
Console.WriteLine("\n--------------------------------");

Console.WriteLine("Numbers from for loop");

for(int number_3 = 1; number_3 <= 10; number_3++)
{
    Console.Write(number_3 + " ");
}
Console.WriteLine("\n--------------------------------");

Console.WriteLine("Numbers from for loop descending");

for(int number_4 = 10; number_4 >= 1; number_4--)
{
    Console.Write(number_4 + " ");
}
Console.WriteLine("\n--------------------------------");

Console.WriteLine("Numbers from for loop even");

for(int number_5 = 0; number_5 <= 20; number_5++)
{
    if (number_5 % 2 == 0)
    {
        Console.Write(number_5 + " ");
    }
}
Console.WriteLine("\n--------------------------------");

Console.WriteLine("Start!");