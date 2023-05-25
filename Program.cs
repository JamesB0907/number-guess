using System;

namespace NumberGuess
{
    class Program
    {
        static void Main()
        {
            int secretNumber;
            int maxGuesses;
            int currentGuess = 0;
            int userGuess;
            bool success = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            string difficultyLevel = PromptDifficultyLevel();
            switch (difficultyLevel)
            {
                case "Easy":
                    maxGuesses = 8;
                    break;
                case "Medium":
                    maxGuesses = 6;
                    break;
                case "Hard":
                    maxGuesses = 4;
                    break;
                case "Cheater":
                    maxGuesses = int.MaxValue;
                    break;
                default:
                    Console.WriteLine("Invalid difficulty level. Starting with Medium difficulty.");
                    maxGuesses = 6;
                    break;
            }

            Random random = new Random();
            secretNumber = random.Next(1, 101);

            while (currentGuess < maxGuesses && !success)
            {
                currentGuess++;
                Console.Write($"Your guess ({currentGuess})> ");

                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the secret number.");
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("Sorry, you did not guess the secret number.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string PromptDifficultyLevel()
        {
            Console.WriteLine("Select a difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Cheater");

            Console.Write("Enter the difficulty level number: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    return "Easy";
                case 2:
                    return "Medium";
                case 3:
                    return "Hard";
                case 4:
                    return "Cheater";
                default:
                    return "Medium";
            }
        }
    }
}
