int sum(int n, int m)
{
    if (n == 0) 
    return (m * (m + 1)) / 2;            
    else if (m == 0) 
    return (n * (n + 1)) / 2;            
    else if (n == m) 
    return n;                             
    else if (n < m) 
    return m + sum(n, m - 1);
    else 
    return m + sum(n, m + 1);            
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));