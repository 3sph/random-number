using System;

namespace random_number_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PlayGame();
                Console.Write("Do you want to play again? (yes/no): ");
            } while (Console.ReadLine().ToLower() == "yes");
        }

        static void PlayGame()
        {
            Console.WriteLine("Welcome to the numbers game!");

            // Generate a random number between 1 and 100
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            int userGuess;
            int attempts = 0;

            do
            {
                Console.Write("Guess a number (between 1 and 100): ");
                string userInput = Console.ReadLine();

                // Check if the user input is a valid integer
                if (int.TryParse(userInput, out userGuess))
                {
                    attempts++;
                    if (userGuess == targetNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the correct number {targetNumber} in {attempts} attempts.");
                        return;
                    }
                    else if (userGuess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (true);
        }
    }
}