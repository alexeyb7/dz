/*/ Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/
double[] CreateArray(int Length) //создание массива
{
    double[] numbers = new double[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().NextDouble();
    }
    return numbers;
}
int ReadInt(string arg)
{
    Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

void PrintArray(double[] numbers) // печать массива
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + "; ");
    }
    Console.WriteLine(numbers[numbers.Length - 1] + "]");
}

void CalcArray(double[] numbers) //вычисление разницы между max и min
{
    double min = numbers[0];
    double max = numbers[0];
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (min > numbers[i + 1])
        {
            min = numbers[i + 1];
        }
        if (max < numbers[i + 1])
        {
            max = numbers[i + 1];
        }

    }
    Console.WriteLine($"Разница между: {max} и {min} равна {max - min}");
}

int Length = ReadInt("длину массива");

double[] numbers = CreateArray(Length);

PrintArray(numbers);
CalcArray(numbers);
