void InputMatrix(int[,,] matrix)
{
    int l = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = l;
                l = l + 1;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i, j, k]}{(i,j,k)}");
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0] * size[1] * size[2] > 99 || size[0] * size[1] * size[2] < 10)
{
    Console.WriteLine("Матрица должна состоять только из двузначных чисел");
}
else
{
int[,,] matrix = new int[size[0], size[1], size[2]];
Console.WriteLine("Трёхмерная матрица:");
InputMatrix(matrix);
PrintMatrix(matrix);
}