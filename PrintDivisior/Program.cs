using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintDivisors(number);
    } // Main

    static void PrintDivisors(int number)
    {
        for (int i = 1; i < number; i++)
            if (number % i == 0)
            {
                Console.WriteLine($"{number} is divisible by {i}");
            }
    } // PrintDivisors
} // Program
