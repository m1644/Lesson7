// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max) // Задать двумерный массив
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr) // Печать двумерного массива
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void ChengeMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (row % 2 != 0 && column % 2 != 0) 
            matrix[row, column] = matrix[row, column] * matrix[row, column];
        }
    }
}

int[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
ChengeMatrix(matrix);
PrintMatrix(matrix);
