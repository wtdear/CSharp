using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество дисков: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1 || n > 8)
        {
            Console.Clear();
            Console.WriteLine("Неверное количество дисков ( от 1 до 8 )\n");
            Main();
        }

        int movingCount = 0;

        Console.WriteLine($"Последовательность перемещений для {n} дисков:");
        SolveHanoi(n, ref movingCount);

        Console.WriteLine($"Общее количество перемещений: {movingCount}");
    }

    static void SolveHanoi(int n, ref int movingCount, char from = 'A', char to = 'C', char aux = 'B')
    {
        if (n > 0)
        {
            SolveHanoi(n - 1, ref movingCount, from, aux, to);
            Console.WriteLine($"{from} -> {to}");
            movingCount++;
            SolveHanoi(n - 1, ref movingCount, aux, to, from);
        }
    }
}
