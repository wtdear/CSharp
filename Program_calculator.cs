using System;

public class Calculator
{
    public static (double first_number, double second_number) GetNum()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        return (num1, num2);
    }

    public static void Menu()
    {
        string menu = @"
╔══════════════════════════╗
║        КАЛЬКУЛЯТОР       ║
╠══════════════════════════╣
║ 1. Сложение (+)          ║
║ 2. Вычитание (-)         ║
║ 3. Умножение (*)         ║
║ 4. Деление (/)           ║
║ 5. Степень (^)           ║
║ 6. Выход                 ║
╚══════════════════════════╝";

        Console.WriteLine(menu);
    }

    public static void Calculate()
    {
        while (true)
        {
            Menu();
            Console.Write("\nВыберите действие: ");
            char userChoice = Convert.ToChar(Console.ReadLine());

            if (userChoice == '6') break;

            var numbers = GetNum();
            double num1 = numbers.first_number;
            double num2 = numbers.second_number;
            double result = 0;
            string operation = "";

            switch (userChoice)
            {
                case '1':
                    result = num1 + num2;
                    operation = "+";
                    break;

                case '2':
                    result = num1 - num2;
                    operation = "-";
                    break;

                case '3':
                    result = num1 * num2;
                    operation = "*";
                    break;

                case '4':

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        operation = "/";
                    }

                    else
                    {
                        Console.WriteLine("Делить на ноль нельзя");
                        continue;
                    }
                    break;

                case '5':
                    result = Math.Pow(num1, num2);
                    operation = "^";
                    break;

                default:
                    Console.WriteLine("Неверный выбор");
                    continue;
            }

            Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}\n");
        }
    }
}
public class Program
{
    public static void Main()
    {
        Calculator.Calculate();
    }
}