//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int height = new Random().Next(3, 7); // задание размеров массива
int length = new Random().Next(3, 7);

int[,] arr = FillArray(height, length);
PrintArray(arr);
Console.WriteLine();
AvgArray(arr);

int[,] FillArray(int height, int length) // задание массива
{
    int[,] array = new int[height, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}


void AvgArray(int[,] array) // печать среднего арифметического столбцов массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($" {(float)sum / array.GetLength(0)}");
    }
}
