// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int height = new Random().Next(3, 7); // задание размеров массива
int length = new Random().Next(3, 7);

int[,] arr = FillArray(height, length);
PrintArray(arr);
Console.WriteLine();
InputUserRowCol(arr);

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


void InputUserRowCol(int[,] array) // ввод строки и столбца пользователем 
{
    int row;
    int col;
    Console.WriteLine("Введите номер строки");
    int.TryParse(Console.ReadLine(), out row);
    Console.WriteLine("Введите номер столбца");
    int.TryParse(Console.ReadLine(), out col);

    if (0 <= row & row < array.GetLength(0) & 0 <= col & col < array.GetLength(1))
        Console.WriteLine(array[row, col]);
    else Console.WriteLine("Элемента в заданных строке и столбце нет");
}
