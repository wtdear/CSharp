using System;

class Program
{
    static int stepCount = 0;
    static bool pathFound = false;

    static void Main()
    {
        char[,] labirint = new char[11, 11]
        {
            { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' },
            { 'M', ' ', ' ', ' ', ' ', ' ', ' ', 'M', ' ', ' ', ' ' },
            { 'M', 'M', ' ', 'M', ' ', 'M', ' ', 'M', ' ', 'M', 'M' },
            { 'M', ' ', ' ', 'M', ' ', 'M', 'M', 'M', ' ', 'M', 'M' },
            { 'M', 'M', ' ', 'M', ' ', 'M', ' ', ' ', ' ', ' ', 'M' },
            { 'M', 'M', ' ', 'M', ' ', ' ', ' ', 'M', 'M', 'M', 'M' },
            { 'M', 'M', ' ', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' },
            { 'M', 'M', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'M' },
            { 'M', ' ', ' ', 'M', ' ', 'M', 'M', 'M', ' ', 'M', 'M' },
            { 'M', 'M', 'M', 'M', ' ', ' ', ' ', ' ', ' ', ' ', 'M' },
            { 'M', ' ', ' ', ' ', 'M', 'M', 'M', 'M', ' ', 'M', 'M' }
        };

        char[,] labirintCopy = (char[,])labirint.Clone();

        bool found = Go(labirintCopy, 1, 10, 10, 8);

        if (found)
        {
            Console.WriteLine($"\nНайденный путь, количество шагов: {stepCount}");
            PrintLab(labirintCopy, true);
        }
    }

    static bool Go(char[,] lab, int x, int y, int targetX, int targetY)
    {
        if (pathFound) return true;
        
        if (x < 0 || x >= lab.GetLength(0) || y < 0 || y >= lab.GetLength(1))
            return false;

        if (lab[x, y] == ' ')
        {
            lab[x, y] = '+';
            stepCount++;

            if (x == targetX && y == targetY)
            {
                pathFound = true;
                return true;
            }

            bool success = 
                Go(lab, x, y + 1, targetX, targetY) ||
                Go(lab, x + 1, y, targetX, targetY) ||
                Go(lab, x, y - 1, targetX, targetY) ||
                Go(lab, x - 1, y, targetX, targetY);  

            if (success)
            {
                pathFound = true;
                return true;
            }

            lab[x, y] = ' ';
            stepCount--;
        }

        return false;
    }

    static void PrintLab(char[,] lab, bool showSteps)
    {
        for (int i = 0; i < lab.GetLength(0); i++)
        {
            for (int j = 0; j < lab.GetLength(1); j++)
            {
                if (showSteps && lab[i, j] == '+')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(lab[i, j] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(lab[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
