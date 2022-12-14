void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101);
}


void SearchMaxMinDiff(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            max = array[i];
        }
    Console.WriteLine($"Максимальное число в массиве: {max}");

    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            min = array[i];
        }
    Console.WriteLine($"Минимальное число в массиве: {min}");

    int diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным числами в массиве: {diff}");
}


Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array= new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
SearchMaxMinDiff(array);