using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"Разработал Баньковский Денис
Группа 106-Д9-2ИСП
Вариант 2.
Задание - 2. Сформировать массивы A{15} и B{7}. Вывести их. Используя метод, найти максимальные элементы массивов.");
        
        Random random = new Random();
        
        int[] A = GenerateArray(15, random);
        Console.Write("\nArray A: ");
        PrintArray(A);
        
        int[] B = GenerateArray(7, random);
        Console.Write("Array B: ");
        PrintArray(B);

        int maxA = FindMaxValue(A);
        int maxB = FindMaxValue(B);

        Console.WriteLine($"\nМаксимальный элемент массива A: {maxA}");
        Console.WriteLine($"Максимальный элемент массива B: {maxB}");
    }
    
    static int[] GenerateArray(int size, Random random)
    {
        int[] array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 9);
        }
        
        return array;
    }
    
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    
    static int FindMaxValue(int[] array)
    {   
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        
        return max;
    }
}
