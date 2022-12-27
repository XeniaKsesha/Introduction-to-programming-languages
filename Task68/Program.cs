int akkerman(int n, int m)
{
 if (n == 0)
 return m + 1;

 else if (m == 0 && n > 0)
 return akkerman(n - 1, 1);

 else
 return (akkerman(n - 1, akkerman(n, m - 1)));
}

Console.Clear();
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(akkerman(n, m));