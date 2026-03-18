using System;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Year = 2000;
    }
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void Print()
    {
        Console.WriteLine($@"Title: {Title},
Author: {Author},
Year: {Year}");
    }

    class Counter
    {
        private int count;

        public Counter()
        {
            count = 0;
        }

        public Counter(int initialValue)
        {
            count = initialValue;
        }

        public void Increment() { count++; }
        public void Decrement() { count--; }

        public int Value
        {
            get { return count; }
        }
    }

    class Program
    {
        static void Main()
        {
            Counter counter1 = new Counter();
            
            Book book1 = new Book();
            Console.WriteLine("First book:\n");
            counter1.Increment();
            book1.Print();

            Book book2 = new Book("Война и мир", "Лев Толстой", 1869);
            Console.WriteLine("Second book:\n");
            counter1.Increment();
            book2.Print();

            Console.WriteLine($"Books value: {counter1.Value}");
        }
    }
}
