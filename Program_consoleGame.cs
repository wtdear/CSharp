using System;
using System.Text;


namespace minigame
{
    internal class Program
    {
        public static string Generator(int length)
        {
            // => => =>  GENERATING  <= <= <=

            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            sb.Append(random.Next(1, 10));
            for (int i = 1; i < length; i++)
            {
                sb.Append(random.Next(0, 10));
            }

            return sb.ToString();
        }

        public class AnswerCheck
        {
            public static (int correctPosition, int correctDigits) CheckAnswer(string password, string userAnswer)
            {
                int correctPosition = 0;
                int correctDigits = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] == userAnswer[i])
                    {
                        correctPosition++;
                    }
                }

                Dictionary<char, int> passwordDigits = new Dictionary<char, int>();
                Dictionary<char, int> answerDigits = new Dictionary<char, int>();

                for (char digit = '0'; digit <= '9'; digit++)
                {
                    passwordDigits[digit] = 0;
                    answerDigits[digit] = 0;
                }

                foreach (char digit in password)
                {
                    passwordDigits[digit]++;
                }

                foreach (char digit in userAnswer)
                {
                    answerDigits[digit]++;
                }

                for (char digit = '0'; digit <= '9'; digit++)
                {
                    correctDigits += Math.Min(passwordDigits[digit], answerDigits[digit]);
                }

                correctDigits -= correctPosition;

                return (correctPosition, correctDigits);
            }

            public static string GetHint(string password, string userAnswer)
            {
                var result = CheckAnswer(password, userAnswer);
                return $"Correct pos: {result.correctPosition}, uncorrect pos: {result.correctDigits}";
            }
        }

        static void Main(string[] args)
        {

            //          => => =>  GAME MENU  <= <= <=

            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();
                Console.Write("\nWonna try again? (Y/N): ");
                string response = Console.ReadLine();
                playAgain = response.ToUpper() == "Y";
                Console.Clear();
            }

            Console.WriteLine("Thank you for playing <3");
        }

        static void PlayGame()
        {
            string text = @"=== You need to guess the password, ===
=== you have a limited number of attempts. ===

1) Easy (password length - 4, attempts - 10)
2) Medium (password length - 4, attempts - 5)
3) Hard (password length - 6, attempts - 6)
4) Unreal (password length - 8, attempts - 4)

0) Exit game";

            Console.WriteLine(text);
            Console.Write("\nWelcome! Please, select game level: ");
            char change = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int pass_len = 0;
            int maxAttempts = 0;
            string password = "";

            switch (change)
            {
                case '1':
                    pass_len = 4;
                    maxAttempts = 10;
                    password = Generator(pass_len);
                    break;
                case '2':
                    pass_len = 4;
                    maxAttempts = 5;
                    password = Generator(pass_len);
                    break;
                case '3':
                    pass_len = 6;
                    maxAttempts = 6;
                    password = Generator(pass_len);
                    break;
                case '4':
                    pass_len = 8;
                    maxAttempts = 4;
                    password = Generator(pass_len);
                    break;
                case '0':
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Starting Easy mode.");
                    pass_len = 4;
                    maxAttempts = 10;
                    password = Generator(pass_len);
                    break;
            }

            Console.WriteLine($"\nYou have to guess a password of length = {pass_len}");
            Console.WriteLine($"You have {maxAttempts} attempts.");

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"\nAttempt {attempt}/{maxAttempts}. Your answer: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.Length != pass_len)
                {
                    Console.WriteLine($"Error! Password must be {pass_len} digits long.");
                    attempt--;
                    continue;
                }

                if (!userAnswer.All(char.IsDigit))
                {
                    Console.WriteLine("Error! Password must contain only digits.");
                    attempt--;
                    continue;
                }

                if (userAnswer == password)
                {
                    Console.WriteLine("You win!");
                    return;
                }
                else
                {

                    string hint = AnswerCheck.GetHint(password, userAnswer);
                    Console.WriteLine(hint);

                    if (attempt == maxAttempts)
                    {
                        Console.WriteLine("\nGame Over!");
                        Console.WriteLine($"Correct password was: {password}");
                    }
                }
            }
        }
    }
}