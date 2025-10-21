// план - написать код - раскидать его по файлам - навести чистоту таким образом
using System;

public class ProgramMenu
{
    public void DisplayMenu()
    {
        string menu = @"
Terminal Windows:

1. Change Directory
2. Make Directory
3. Remove Directory (all files)
4. Rename Directory
5. Move Directory
6. Create file
7. Open file
8. Commands information

0) Exit terminal

What u want?:
";
        Console.Write(menu);
    }

    public void PersonChoice(char choice)
    {
        switch (choice)
        {
            case '1':
                ChangeDirectory();
                break;
            case '2':
                MakeDirectory();
                break;
            case '3':
                RemoveDirectory();
                break;
            case '4':
                RenameDirectory();
                break;
            case '5':
                MoveDirectory();
                break;
            case '6':
                CreateFile();
                break;
            case '7':
                OpenFile();
                break;
            case '8':
                CommandsInformation();
                break;
            case '0':
                Console.WriteLine("Program was closed");
                break;

            default:
                break;
        }
    }

    private void ChangeDirectory()
    {
        Console.Write("Enter directory path: ");
        string path = Console.ReadLine();
        Console.WriteLine($"Your location is: {path}");
    }

    private void MakeDirectory()
    {
        Console.Write("Enter directory name: ");
        string dirName = Console.ReadLine();
        Console.WriteLine($"Your new directory is: {dirName}");
    }

    private void RemoveDirectory()
    {
        Console.Write("Enter dirctory path to remove: ");
        string dirPath = Console.ReadLine();
        Console.WriteLine($"{dirPath} was deleted");
    }

    private void RenameDirectory()
    {
        Console.Write("Enter directory name: ");
        string dirName = Console.ReadLine();
        Console.Write("New directory name: ");
        string newDirName = Console.ReadLine();
        Console.WriteLine($"{dirName} was renamed to {newDirName}");
    }

    private void MoveDirectory()
    {
        Console.Write("Enter directory name: ");
        string dirName = Console.ReadLine();
        Console.Write("Enter new path: ");
        string path = Console.ReadLine();
        Console.WriteLine($"{dirName} was moved to {path}");
    }

    private void CreateFile()
    {
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();
        Console.WriteLine($"File {file} was created");
    }

    private void OpenFile()
    {
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();
        Console.WriteLine($"File {file} was open");
    }

    private void CommandsInformation()
    {
        string commads = @"
cd - change directory
mkdir - make directory
rm -r - remove directory

";
    }

}

public class Logic
{
    private ProgramMenu menu;

    public Logic()
    {
        menu = new ProgramMenu();
    }

    public void Run()
    {
        char choice;
        do
        {
            Console.Clear();
            menu.DisplayMenu();
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // New line after input

            menu.PersonChoice(choice);

            if (choice != '0')
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        } while (choice != '0');
    }
}

// Main program class
public class Program
{
    public static void Main(string[] args)
    {
        Logic programLogic = new Logic();
        programLogic.Run();
    }
}

