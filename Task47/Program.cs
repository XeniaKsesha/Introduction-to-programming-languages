//проблема с конвертацией int double

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 11)) / 10;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
double[] size = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[0]];
InputMatrix(matrix);