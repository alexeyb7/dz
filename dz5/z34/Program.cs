/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int[] CreateArray(int Length, int min, int max) //создание массива
{
    int[] numbers = new int[Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);
    }
    return numbers;
}
int ReadInt(string arg)
{
    Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] numbers) // печать массива
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + "; ");
    }
    Console.WriteLine(numbers[numbers.Length - 1] + "]");
}

void CalcArray(int[] numbers) //вычисление количества четных чисел в массиве
{
    int calc = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            calc++;
        }
    }
    Console.WriteLine($"Четных чисел в массиве: {calc}");
}

int Length = ReadInt("длину массива");
int min = ReadInt("минимальное значение массива");
int max = ReadInt("максимальное значение массива");
int[] numbers = CreateArray(Length, min, max);

PrintArray(numbers);
CalcArray(numbers);