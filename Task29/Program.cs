Console.Clear();

Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент для массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{String.Join("; ", array)}]");