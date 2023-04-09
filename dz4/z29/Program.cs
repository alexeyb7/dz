// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
int CreateArray()
{
    System.Console.Write("Введите длину массива: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int[] Array = new int[CreateArray()];
Console.Write("[");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 30);
    Console.Write($" {Array[i]}");
}
Console.Write(" ]");

