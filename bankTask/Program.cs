using System;

internal class Program
{
    static void Main()
    {
        Console.Write("Введите значение суммы вклада - ");
        double contribution = Convert.ToDouble(Console.ReadLine());

        if (contribution > 0 && contribution <= 99)
        {
            double dopMoney = contribution * 0.05;
            contribution += dopMoney;
            Console.WriteLine($"Общая сумма - {contribution} рубиков.");            
        }    
        else if (contribution >= 100 && contribution <= 200)
        {
            double dopMoney = contribution * 0.07;
            contribution += dopMoney;
            Console.WriteLine($"Общая сумма - {contribution} рубиков.");
        } 
        else if (contribution >= 201)
        {
            double dopMoney = contribution * 0.10;
            contribution += dopMoney;
            Console.WriteLine($"Общая сумма - {contribution} рубиков.");
        } 
        else
        {
            Console.WriteLine("Сумма вклада не может быть отрицательной\nили вы ввели некорректное значение.\n");
            Main();
        }    
    }
}