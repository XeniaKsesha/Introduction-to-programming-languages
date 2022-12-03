Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n % 10;

if (n <= 99)
Console.WriteLine("Третьего числа нет");

    {
        if (n >= 100 && n <= 999)
        Console.WriteLine(m);
    }
while (n > 1000)
{
    n = n / 10;
    Console.WriteLine(m);
}

// осталась проблема с более чем 3-х значными числами, не могу найти проблему в цикле вайл