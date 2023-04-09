/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Возведение числа А в степень В");

int A = Read("A");
int B = Read("B");

int Read(string argument)
{
    Console.WriteLine($"Введите число: {argument}");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int expon(int A, int B)
{
    int rez = 1;
    for (int i = 0; i < B; i++)
    {
        rez = rez * A;
    }
    return rez;
}

int C = expon(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {C}");