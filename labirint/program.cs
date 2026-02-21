// add count add optim path
using System;
using System.Collections.Generic;

class Program
{
    static char[,] labirint = new char[11, 11]
    {
        { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' },
        { 'M', ' ', ' ', ' ', ' ', ' ', ' ', 'M', ' ', ' ', 'А' },
        { 'M', 'M', ' ', 'M', ' ', 'M', ' ', 'M', ' ', 'M', 'M' },
        { 'M', ' ', ' ', 'M', ' ', 'M', 'M', 'M', ' ', 'M', 'M' },
        { 'M', 'M', ' ', 'M', ' ', 'M', ' ', ' ', ' ', ' ', 'M' },
        { 'M', 'M', ' ', 'M', ' ', ' ', ' ', 'M', 'M', 'M', 'M' },
        { 'M', 'M', ' ', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M' },
        { 'M', 'M', ' ', ' ', ' ', ',', ' ', ' ', ' ', ' ', 'M' },
        { 'M', ' ', ' ', 'M', ' ', 'M', 'M', 'M', ' ', 'M', 'M' },
        { 'M', 'M', 'M', 'M', ' ', ' ', ' ', ' ', ' ', ' ', 'M' },
        { 'M', ' ', ' ', ' ', 'M', 'M', 'M', 'M', ' ', 'M', 'M' }
    };

    static List<List<(int, int)>> paths = new List<List<(int, int)>>();
    static int rows = 11;
    static int cols = 11;

    static void Main()
    {
        int startRow = -1, startCol = -1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (labirint[i, j] == 'А')
                {
                    startRow = i;
                    startCol = j;
                    break;
                }
            }
            if (startRow != -1) break;
        }

        if (startRow == -1)
        {
            Console.WriteLine("Стартовая позиция не найдена!");
            return;
        }

        List<(int, int)> currentPath = new List<(int, int)>();
        FindPaths(startRow, startCol, currentPath);

        Console.WriteLine($"Найдено путей: {paths.Count}\n");

        for (int i = 0; i < paths.Count; i++)
        {
            Console.WriteLine($"Путь {i + 1}:");
            PrintMazeWithPath(paths[i]);
            Console.WriteLine();
        }
    }

    static void FindPaths(int row, int col, List<(int, int)> currentPath)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols)
            return;

        if (labirint[row, col] == 'M' || labirint[row, col] == '+')
            return;

        currentPath.Add((row, col));

        if (row == 0 || row == rows - 1 || col == 0 || col == cols - 1)
        {
            if (labirint[row, col] == ' ')
            {
                paths.Add(new List<(int, int)>(currentPath));
                currentPath.RemoveAt(currentPath.Count - 1);
                return;
            }
        }

        char temp = labirint[row, col];
        labirint[row, col] = '+';

        FindPaths(row - 1, col, currentPath);
        FindPaths(row + 1, col, currentPath);
        FindPaths(row, col - 1, currentPath);
        FindPaths(row, col + 1, currentPath);

        labirint[row, col] = temp;
        currentPath.RemoveAt(currentPath.Count - 1);
    }

    static void PrintMazeWithPath(List<(int, int)> path)
    {
        char[,] displayMaze = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                displayMaze[i, j] = labirint[i, j];
            }
        }

        foreach (var pos in path)
        {
            int r = pos.Item1;
            int c = pos.Item2;

            if (displayMaze[r, c] == 'А')
                continue;

            displayMaze[r, c] = '+';
        }

        for (int i = 0; i < rows; i++)  
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(displayMaze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
