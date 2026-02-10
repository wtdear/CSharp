using System;

class Program
{
    static void Main()
    {
        Console.Write("Числитель: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Знаменатель: ");
        int y = Convert.ToInt32(Console.ReadLine());
        ReduceFraction(ref x, ref y);
    }

    static void ReduceFraction(ref int x, ref int y)
    {
        int naib = NOD(Math.Abs(x), Math.Abs(y));

        Console.WriteLine($"НОД = {naib}");

        if (naib > 1)
        {
            x /= naib;
            y /= naib;
            Console.Write($"Сокращенная дробь - {x}/{y}");
        }
        else
        {
            Console.WriteLine("Дробь несократима");
        }
    }

    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
