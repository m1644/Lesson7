// Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Amn = m+n. Выведите полученный массив на экран.

void CreateMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 4];

CreateMatrix(array);
PrintMatrix(array);
