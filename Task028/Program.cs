using System;

class Program
{
    public static void Main(string[] args)
    {
        /* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
       M = 1; N = 15 -> 120
       M = 4; N = 8. -> 30 */
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        int temp = 0;

        if (m > n)
        {
            temp = m;
            m = n;
            n = temp;
        }

        //Рекурсия
        int SumRec(int m, int n)
        {
            if (m == n) return n;
            else return n + SumRec(m, n - 1);
        }

        Console.Write($"Суммма чисел в интервале от M до N: {SumRec(m, n)}");

        /* Итеративный метод

        int Sum(int m, int n)
        {
         int result = 0;
         for (int i = m; i <= n; i++)
         {
           result += i;
         } 
         return result;
        }
        */


    }
}