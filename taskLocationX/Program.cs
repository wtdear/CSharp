using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
        {
            double y = Math.Sin(x);
            Console.WriteLine($"Ваш Y: {y}"); 
        }
        else
        {
            double y = Math.Cos(x);
            Console.WriteLine($"Ваш Y: {y}"); 
        }
    }
}