void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix [i, j] = new Random().Next(1, 11);
    }
}


void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void FindString(int[,] matrxix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrxix.GetLength(1); i++)
    {
        minRow = minRow + matrxix[0, i];
    }
    for (int i = 0; i < matrxix.GetLength(0); i++)
    {
        for (int j = 0; j < matrxix.GetLength(1); j++) sumRow = sumRow + matrxix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}


Console.Clear();
int [] size = Console.ReadLine().Split(" ").Select (x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
Console.WriteLine("Массивчик: ");
InputMatrix(matrix);
PrintMatrix(matrix);
FindString(matrix);