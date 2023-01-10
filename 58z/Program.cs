void InputMatrix(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            matrix1[i, j] = new Random().Next(1, 11);
    }

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = new Random().Next(1, 11);
    }
}

void PrintMatrix(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine("Первая матрица:");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            Console.Write($"{matrix1[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Вторая матрица:");
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write($"{matrix2[i, j]} \t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    Console.WriteLine("Третья матрица:");
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
            Console.Write($"{matrix3[i, j] = matrix1[i, j] * matrix2[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размер второй матрицы: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
if (matrix1[0, 0] == matrix2[0, 0] && matrix1[1, 1] == matrix2[1, 1])
{
    int[,] matrix3 = new int [size1[0], size2[1]];
    InputMatrix(matrix1, matrix2);
    PrintMatrix(matrix1, matrix2);
    Console.WriteLine();
    ReleaseMatrix(matrix1, matrix2, matrix3);
}
else
{
    Console.WriteLine("Введены матрицы разной размерности");
}