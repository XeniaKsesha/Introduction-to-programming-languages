//не факт, что всё как надо
//возможно что-то не так с count и ограничением на повторение среди двухзначных

void Input3DMatrix(int[,,] matrix3D)
{
    int count = 10;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D [k, i, j] = count + count;
                count = count + 1;
            }
        }
    }
}


void Print3DMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix3D.GetLength(2); k++)
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
        }
    }
}


Console.Clear();
int[,,] matrix3D = new int[2, 2, 2];
Input3DMatrix(matrix3D);
Print3DMatrix(matrix3D);