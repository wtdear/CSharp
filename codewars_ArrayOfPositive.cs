//You get an array of numbers, return the sum of all of the positives ones. [1, -4, 7, 12]

using System;

class Program
{
    static void Main()
    {
        List<int> list = [1, -4, 7, 12];
        int sum = 0;

        foreach (int number in list)
        {
            if (number > 0)
            {
                sum += number;
            }
        }
        Console.WriteLine(sum);
    }
}