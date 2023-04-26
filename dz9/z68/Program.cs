/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Akkrmn(m, n));

int Akkrmn(int m, int n) //вычисление функции Аккермана
{
    if (m == 0)
        return n + 1;
    else
        if ((m != 0) && (n == 0))
        return Akkrmn(m - 1, 1);
    else
        return Akkrmn(m - 1, Akkrmn(m, n - 1));
}