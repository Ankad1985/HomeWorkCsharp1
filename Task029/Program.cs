using System;

class Program
{
    public static void Main(string[] args)
    {
        /* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        m = 2, n = 3 -> A(m,n) = 9 */

        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int Ack(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Ack(m - 1, 1);
            else return Ack(m - 1, Ack(m, n - 1));
        }

        int functionAkkerman = Ack(m, n);
        Console.Write($"Функция Аккермана = {functionAkkerman} ");

    }
}