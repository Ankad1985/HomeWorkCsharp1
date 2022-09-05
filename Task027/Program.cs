using System;

class Program
{
    public static void Main(string[] args)
    {
        /* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    M = 1; N = 5. -> ""1, 2, 3, 4, 5""
    M = 4; N = 8. -> ""4, 6, 7, 8"" */

        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        int temp = 0;

        if (m <= 0 || n <= 0)
        {
            Console.WriteLine("Введены некорректные данные");
        }

        if (m > n)
        {
            temp = m;
            m = n;
            n = temp;
        }

        for (int i = m; i <= n; i++)
        {
            Console.Write($"{i} ");
        }

    }
}