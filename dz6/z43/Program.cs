/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int ReadInt(string arg)
{
    Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

int b1 = ReadInt("число B1");
int b2 = ReadInt("число B2");
int k1 = ReadInt("число К1");
int k2 = ReadInt("число К2");

double x = (double)(b1 - b2) / (k2 - k1);
double y = x;

Console.WriteLine($"Координаты точки пересечения x:{x}, y:{y} ");