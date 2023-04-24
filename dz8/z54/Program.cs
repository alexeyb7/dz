//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] arr = CreateArray(4, 5);
PrintArray(arr);
Console.WriteLine();
CorectArray(arr);
PrintArray(arr);

int[,] CreateArray(int m, int n) // создание массива
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 10);
        }
    }
    return array;
}

int[,] CorectArray(int[,] array) // сортировка массива по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                int temp = array[i, k];
                if (array[i, k] < array[i, k + 1])
                {
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }

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
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}
