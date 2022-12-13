Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= m; i++)
result = result * n;
Console.WriteLine(result);