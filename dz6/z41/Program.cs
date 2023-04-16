/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3.*/
int[] CreateArray(int Length) //создание массива
{
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Введите число: ");
        numbers[i] = int.Parse(Console.ReadLine());
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

void CalcArray(int[] numbers) //вычисление колмчества чисел больше 0
{
    int calc = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) calc++;
    }
    Console.WriteLine($"Количество чисел больше 0 равно {calc}");
}

int Length = ReadInt("количество чисел");

int[] numbers = CreateArray(Length);

PrintArray(numbers);
CalcArray(numbers);

