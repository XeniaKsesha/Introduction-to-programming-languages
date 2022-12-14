﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}


void ReleaseArray(int[] array)
{
    int EvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        EvenNumbers = EvenNumbers + 1;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers}");
}


Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);