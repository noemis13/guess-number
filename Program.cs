// See https://aka.ms/new-console-template for more information

using System;

class Program
{

    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 1000);

        Console.WriteLine("=============================");
        Console.WriteLine("Welcome to Guess The Number! ");
        Console.WriteLine("=============================");
        Console.WriteLine("\n Press any key to continue, or 0 to exit game");

        string userInput = Console.ReadLine();

        if (userInput == "0")
        {
            Console.WriteLine("Exiting the game...");
            return; // Exit the method/game
        }
        else
        {
            StartGame(numberToGuess); // Continue the game
        }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gameNumber"></param>
    static void StartGame(int gameNumber)
    {
        int guessedNumber = -1;
        bool numberGuessed = false;
        int wrongAttempts = 0;

        while (numberGuessed != true)
        {
            Console.WriteLine("\n Try to guess a number from 1 to 1000: ");
            String userGuess = Console.ReadLine();

            // Validate user input. Only Int are accepted
            if (!int.TryParse(userGuess, out guessedNumber))
            {
                Console.WriteLine("\n Invalid input! Please enter a number.");
                continue;
            }

            // validate number provided by user
            if (guessedNumber != gameNumber)
            {

                // Give a hint to the users
                GiveHint(guessedNumber, gameNumber);
                wrongAttempts++;

            }
            else
            {
                Console.WriteLine($"\n\n Congratulations! You guessed the number {gameNumber} in {wrongAttempts} attempts.");
                break;
            }

        }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userNum"></param>
    /// <param name="gameNum"></param>
    static void GiveHint(int userNum, int gameNum)
    {
        if (userNum < gameNum)
        {
            Console.WriteLine("You should guess a higher number! ");

        }
        else
        {
            Console.WriteLine("You should guess a lower number!");
        }
    }

}
