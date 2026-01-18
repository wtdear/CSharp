using System;

class Program
{
    static void Main()
    {
        for (int number = 100; number <= 999; number++)
        {
            int lastDigit = number % 10;
            int subs = number - lastDigit;
            int divided = subs / 10;
            int result = lastDigit * 100 + divided;
            
            if (result == 237)
            {
                Console.WriteLine(number);
            }
        }
    }
}