// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали с индексами (0,0); (1,1) и т.д.

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

int SumMatrix(int[,] matrix)
{
    int result = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (row == column) result += matrix[row, column];
        }
    }
    return result;
}

int[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
int sum = SumMatrix(matrix);
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");
