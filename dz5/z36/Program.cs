/*/ Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
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

void CalcArray(int[] numbers) //вычисление количества элементов в массиве на нечетных позициях
{
    int calc = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 0)
        {
            calc = calc + numbers[i];
        }
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях в массиве: {calc}");
}

int Length = ReadInt("длину массива");
int min = ReadInt("минимальное значение массива");
int max = ReadInt("максимальное значение массива");
int[] numbers = CreateArray(Length, min, max);

PrintArray(numbers);
CalcArray(numbers);