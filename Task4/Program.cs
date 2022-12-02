Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = " + a);
}
else if (b > c)
{
    Console.WriteLine($"max = " + b);
}
else if (c > b)
{
    Console.WriteLine($"max = " + c);
}