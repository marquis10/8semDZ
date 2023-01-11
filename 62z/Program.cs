void InputMatrix(int[,] matrix)
{
    int c = 1, sk = 1, sb = 0, s = matrix.GetLength(0) / 2;
    if (matrix.GetLength(0) % 2 != 0)
    {
        s = s + 1;
    }
    for (int a = 0; a < s; a++)
    {
        //Вправо
        for (int i = sb; i < sk; i++)
        {
            for (int j = sb; j < matrix.GetLength(1) - sb; j++)
            {
                matrix[i, j] = c;
                c = c + 1;
            }
        }
        //Вниз
        for (int i = sk; i < matrix.GetLength(0) - sb; i++)
        {
            for (int j = matrix.GetLength(1) - sk; j < matrix.GetLength(1) - sb; j++)
            {
                matrix[i, j] = c;
                c = c + 1;
            }
        }
        //Влево
        for (int i = matrix.GetLength(0) - sk; i < matrix.GetLength(0) - sb; i++)
        {
            for (int j = matrix.GetLength(1) - sk -1; j > sb - 1; j--)
            {
                matrix[i, j] = c;
                c = c + 1;
            }
        }
        //Вверх
        for (int i = matrix.GetLength(0) - sk - 1; i > sb; i--)
        {
            for (int j = sb; j < sk; j++)
            {
                matrix[i, j] = c;
                c = c + 1;
            }
        }
        sk++;
        sb++;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица:");
InputMatrix(matrix);
PrintMatrix(matrix);