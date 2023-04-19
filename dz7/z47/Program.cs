// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int height = new Random().Next(3, 7); // задание размеров массива
int length = new Random().Next(3, 7);

double[,] arr = FillArray(height, length);
PrintArray(arr);
Console.WriteLine();


double[,] FillArray(int height, int length) // задание массива
{
    double[,] array = new double[height, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-10, 100);
        }
    }
    return array;
}

void PrintArray(double[,] array) // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{00000:f2}", array[i, j]) + " ");
        }
        Console.WriteLine();
    }
}
