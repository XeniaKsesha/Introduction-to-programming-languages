Console.WriteLine("Введите индекс строки массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,11));
}
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}

Console.WriteLine("---------------");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    sum = Math.Round(sum / array.GetLength(0), 2);
    Console.Write($"{sum}      ");
}