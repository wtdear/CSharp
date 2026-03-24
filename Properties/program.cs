using System;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine(@"Hi, dev. Johhny Kolbaya,
The program solves two tasks: 
1) Creates a person instance (Custom and Default)
2) A circle with a radius validation");
        Menu();
    }

    static void Menu()
    {
        Console.Write(@"
Select a task to run:
0) Exit Program
1) Task 1 (Person Class)
2) Task 2 (Circle Geometry)

Choice - ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "0":
                Environment.Exit(0);
                break;
            case "1":
                RunTask1();
                break;
            case "2":
                RunTask2();
                break;
            default:
                Console.Clear();
                Menu();
                break;
        }
    }

    static void RunTask1()
    {
        Console.Clear();
        Console.WriteLine("--- Task 1: Person Information ---");

        Person p1 = new Person();
        p1.Name = "Benjamin Button";
        p1.Age = 1;
        Console.WriteLine("Default person created:");
        p1.PrintInfo();

        Console.WriteLine("\nNow create your own person:");
        Person pCustom = new Person();

        Console.Write("Enter name: ");
        pCustom.Name = Console.ReadLine();

        Console.Write("Enter age: ");
        pCustom.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("\nYour person details:");
        pCustom.PrintInfo();

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void RunTask2()
    {
        Console.Clear();
        Console.WriteLine("--- Task 2: Circle Calculations ---");

        Circle circle = new Circle();

        Console.Write("Enter circle radius: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double r))
        {
            if (r > 0)
            {
                circle.Radius = r;
                Console.WriteLine($"Radius: {circle.Radius}");
                Console.WriteLine($"Area: {circle.Area:F2}");
                Console.WriteLine($"Circumference: {circle.Circumference:F2}");
            }
            else
            {
                Console.WriteLine("Error: Radius must be greater than zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}
