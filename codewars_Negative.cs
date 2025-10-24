// In this simple assignment you are given a number and have to make it negative.
// But maybe the number is already negative?

using System;

class Program
{
    static void Main()
    {
        Console.Write("Your number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num >= 0 ? num * -1 : num);
    }
}