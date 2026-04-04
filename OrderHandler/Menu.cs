using System;

public class Menu
{
    static public void ShowMenu()
    {
        while (true) 
        {
            Console.Write(@$"1) Choice user
2) Add user
3) Users list
4) Delete user

0) Exit

Your choice - ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Goodbye!");
                    return; 

                case "1":
                    Console.Clear();
                    AccountManagement.ChoiceUser();
                    AccountManagement.ShowCurrentUser();
                    break;

                case "2":
                    Console.Clear();
                    AccountManagement.CreateUser();
                    break; 

                case "3":
                    Console.Clear();
                    AccountManagement.PrintUsers();
                    break; 

                case "4":
                    Console.Clear();
                    AccountManagement.DeleteUser();
                    break; 

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice! Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue; 
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}