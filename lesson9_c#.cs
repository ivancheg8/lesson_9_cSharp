//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
//N = 4532 -> 4

int count = 2;
int SumOfElements(int n)
{
    if (n < 0) n = n * -1;
    if (n == 0) return 1;
    if (n >= 10)
    {
        SumOfElements((n / 10));
        return count++;
    }
    else return 1;
}

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfElements(m));






//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfDigits(int a, int b)
{
    if (a < b)
        return (a + SumOfDigits(a + 1, b));
    if (a > b)
        return (b + SumOfDigits(a, b + 1));
    else return a;
}

Console.Write("Введите первое число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(k, l));
