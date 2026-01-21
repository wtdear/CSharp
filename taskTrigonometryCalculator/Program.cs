using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write(@"Welcome! Choose what you want:

1. Calculate SIN
2. Calculate COS
3. Calculate TG
4. Calculate CTG

Enter your choice: ");
        
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                Console.Clear();
                double angle1 = GetAngle();
                double sinResult = CalculateSin(angle1);
                Console.WriteLine($"SIN({angle1}) = {sinResult}");
                break;

            case "2":
                Console.Clear();
                double angle2 = GetAngle();
                double cosResult = CalculateCos(angle2);
                Console.WriteLine($"COS({angle2}) = {cosResult}");
                break;

            case "3":
                Console.Clear();
                double angle3 = GetAngle();
                double tanResult = CalculateTan(angle3);
                Console.WriteLine($"TG({angle3}) = {tanResult}");
                break;

            case "4":
                Console.Clear();
                double angle4 = GetAngle();
                double ctgResult = CalculateCtg(angle4);
                Console.WriteLine($"CTG({angle4}) = {ctgResult}");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid choice!");
                Main();
                break;
        } // choice ( switch case )
    } // Main

    public static double GetAngle()
    {
        Console.Write("Enter angle in radians: ");
        return Convert.ToDouble(Console.ReadLine());
    } // Get Angle

    public static double CalculateSin(double angle)
    {
        return Math.Sin(angle);
    } // Calculate Sin

    public static double CalculateCos(double angle)
    {
        return Math.Cos(angle);
    } // Calculate Cos

    public static double CalculateTan(double angle)
    {
        return Math.Tan(angle);
    } // Calculate Tang

    public static double CalculateCtg(double angle)
    {
        return 1.0 / Math.Tan(angle);
    } // Calculate Cot
    
} // Program