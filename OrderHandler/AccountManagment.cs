using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Password { get; set; }

    public User(int id, string name, DateTime date, string password)
    {
        Id = id;
        Name = name;
        Date = date;
        Password = password;
    }
}

public class AccountManagement
{
    private static List<User> users = new List<User>();
    private static User currentUser = null;

    public static void CreateUser()
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            int id = new Random().Next(100, 999);
            DateTime date = DateTime.Now;

            User newUser = new User(id, name, date, password);
            users.Add(newUser);
            currentUser = newUser;

            File.AppendAllText("log.log", $"[INFO] [{DateTime.Now}] User was created with ID - {id}, name - {name}\n");
            Console.WriteLine($"User was created, name - {name}, id - {id}");
        }
        catch (Exception ex)
        {
            string errorMessage = $"[ERROR] [{DateTime.Now}] The user entered an invalid password\n";
            File.AppendAllText("log.log", errorMessage);
            return;
        }
    }

    public static void PrintUsers()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("No user data available");
            return;
        }

        Console.WriteLine("\n=== All Users ===");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Reg. date: {user.Date}");
        }

        if (currentUser != null)
        {
            Console.WriteLine($"\n--- Current Selected User ---");
            Console.WriteLine($"ID: {currentUser.Id}\nName: {currentUser.Name}\nReg. date: {currentUser.Date}");
        }
    }

    public static void DeleteUser()
    {
        if (currentUser == null)
        {
            Console.WriteLine("No user selected to delete");
            return;
        }

        users.Remove(currentUser);
        File.AppendAllText("log.log", $"[INFO] [{DateTime.Now}] User {currentUser.Name} (ID: {currentUser.Id}) was deleted\n");
        Console.WriteLine($"User {currentUser.Name} was deleted.");
        currentUser = null;
    }

    public static void ChoiceUser()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("No users available. Please create a user first.");
            return;
        }

        Console.WriteLine("\n=== Select User ===");
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine($"{i + 1}. ID: {users[i].Id}, Name: {users[i].Name}");
        }

        Console.Write("\nEnter user number (or ID to search): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int selection))
        {
            if (selection >= 1 && selection <= users.Count)
            {
                currentUser = users[selection - 1];
                Console.WriteLine($"\nUser selected: {currentUser.Name} (ID: {currentUser.Id})");
                File.AppendAllText("log.log", $"[INFO] [{DateTime.Now}] User selected: {currentUser.Name} (ID: {currentUser.Id})\n");
                return;
            }

            var userById = users.FirstOrDefault(u => u.Id == selection);
            if (userById != null)
            {
                currentUser = userById;
                Console.WriteLine($"\nUser selected by ID: {currentUser.Name} (ID: {currentUser.Id})");
                File.AppendAllText("log.log", $"[INFO] [{DateTime.Now}] User selected by ID: {currentUser.Name} (ID: {currentUser.Id})\n");
                return;
            }
        }

        Console.Write("Enter name to search: ");
        string searchName = Console.ReadLine();

        var userByName = users.FirstOrDefault(u => u.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
        if (userByName != null)
        {
            currentUser = userByName;
            Console.WriteLine($"\nUser selected by name: {currentUser.Name} (ID: {currentUser.Id})");
            File.AppendAllText("log.log", $"[INFO] [{DateTime.Now}] User selected by name: {currentUser.Name} (ID: {currentUser.Id})\n");
        }
        else
        {
            Console.WriteLine("User not found.");
            File.AppendAllText("log.log", $"[WARNING] [{DateTime.Now}] Attempted to select non-existent user: {searchName}\n");
        }
    }

    public static void ShowCurrentUser()
    {
        if (currentUser == null)
        {
            Console.WriteLine("No user currently selected");
        }
        else
        {
            Console.WriteLine($"\nCurrent user: {currentUser.Name} (ID: {currentUser.Id})");
        }
    }
}