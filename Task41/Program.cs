Console.Clear();

int [] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int result = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s [i] > 0)
    result = result + 1;
}
Console.WriteLine($"Чисел больше нуля: {result}");