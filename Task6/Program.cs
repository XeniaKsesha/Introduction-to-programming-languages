Console.Clear();

Console.Write("Это число чётное? Введите число: " );
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");