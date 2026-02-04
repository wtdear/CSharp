using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsArmstrong(number) ? $"{number} is Armstrong number" : $"{number} is not Armstrong number");
    } // Main

    static bool IsArmstrong(int number)
    {
        int original = number;
        int sum = 0;
        int digits = number.ToString().Length;      
        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digits);
            number /= 10;
        }       
        return sum == original;
    } // IsArmstrong
} // Program
