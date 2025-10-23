// Complete the solution so that it reverses the string passed into it.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Your string: ");
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
}
