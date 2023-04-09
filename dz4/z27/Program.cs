/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

string Read()
{
    Console.WriteLine("Введите число: ");
    string str = Console.ReadLine();
    return str;
}

int Sum(string str)
{
    int length = str.Length;
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        summ = summ + (int)Char.GetNumericValue(str[i]);
    }
    return summ;
}

Console.Write(Sum(Read()));