Console.WriteLine("Tell me the number of adventure days");
int days = int.Parse(Console.ReadLine()!);

if(days >= 1 && days <= 7)
{
    int gold_sum = 0;
    int gold_ten = 0;
 for(int i = 1; i <= days; i++)
    {
        Console.WriteLine($"Gold in day: {i}");
        int gold = int.Parse(Console.ReadLine());
        gold_sum += gold;
        if(gold > 10)
        {
            gold_ten++;
        }
    }
    Console.WriteLine($"Summary found: {gold_sum}");
    Console.WriteLine($"Days with gold found above 10: {gold_ten}");   
}
else
{
    Console.WriteLine("Please provide correct number of days");
};