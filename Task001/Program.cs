// Задайте двумерный массив размером mxn, заполненный случайными числами.

//int[] CreateArray(int length, int min, int max) // Задать массив
//{
//    int[] array = new int[length];
//    for (int i = 0; i < length; i++)
//    {
//        array[i] = new Random().Next(min, max+1);
//    }
//    return array;
//}

//void PrintArray(int[] array) // Вывод массива на печать
//{
//    for (int i = 0; i < array.Length; i++)
//        Console.Write($"{array [i]} ");
//    Console.WriteLine();
//}

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

int[,] matrix = CreateMatrix(7, 9, 0, 99);
int length = matrix.Length;
Console.WriteLine($"Общее количество элементов: {length}");
PrintMatrix(matrix);
