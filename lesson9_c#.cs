//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
//N = 4532 -> 4

int a = 2;
int SumOfDigits(int n)
{
    if (n < 0) n = n * -1;
    if (n == 0) return 1;
    if (n >= 10)
    {
        SumOfDigits((n / 10));
        return a++;
    }
    else return 1;
}
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(m));






//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int ShowNumbs(int n, int m)
{
    if (n < m)
        return (n + ShowNumbs(n + 1, m));
    if (n > m)
        return (m + ShowNumbs(n, m + 1));
    else return n;
}
Console.Write("Введите первое число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowNumbs(k, n));
