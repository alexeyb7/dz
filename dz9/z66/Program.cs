/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Count(m, n));

int Count(int m, int n)
{
    int result = n;
    if (n > m)
    {
        n--;
        return result + Count(m, n);
    }
    return result;
}