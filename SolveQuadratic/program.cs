using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите коэффициент A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveQuadratic(a, b, c, out int rootCount, out double x1, out double x2);

        switch (rootCount)
        {
            case 0:
                Console.WriteLine("Корней нет");
                break;
            case 1:
                Console.WriteLine($"Уравнение имеет один корень: x = {x1}");
                break;
            case 2:
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
                break;
        }
    }

    static void SolveQuadratic(double a, double b, double c, out int rootCount, out double x1, out double x2)
    {
        rootCount = 0;
        x1 = 0;
        x2 = 0;

        double D = b * b - 4 * a * c;

        if (D > 0)
        {
            rootCount = 2;
            double sqrtD = Math.Sqrt(D);
            x1 = (-b + sqrtD) / (2 * a);
            x2 = (-b - sqrtD) / (2 * a);
        }
        else if (Math.Abs(D) < double.Epsilon)
        {
            rootCount = 1;
            x1 = -b / (2 * a);
            x2 = x1;
        }
        else
        {
            rootCount = 0;
        }
    }
}
