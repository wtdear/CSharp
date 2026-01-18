using System;

class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;
        bool AorB = A || B;
        bool AandB = A && B;
        bool BorC = B || C;
        Console.WriteLine($"A or B = {AorB}");
        Console.WriteLine($"A and B = {AandB}");
        Console.WriteLine($"B or C = {BorC}");
    }
}