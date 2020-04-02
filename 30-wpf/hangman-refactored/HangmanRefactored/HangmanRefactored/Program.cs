using System;

namespace HangmanRefactored
{
    class Program
    {
        static string secret = "";      // The secret word

        // Revealed Secret (= current user progress; includes correct guessed letters)
        static string revealedSecret = "";

        // The letters that the user already tried
        static string previouslyGuessedLetters = "";

        // Number of wrong guesses left
        static int remainingTries = 5;

        // Show user welcome message
        static void Welcome()
        {
            Console.WriteLine("Welcome to Hangman.");
            Console.WriteLine("I have a word for you to guess.");
            Console.WriteLine("You have a number of guesses or its the gallows.\n");
        }

        // Generate secret word
        static void GenerateSecret()
        {
            string[] secrets = System.IO.File.ReadAllLines(@"words.txt");
            //{
            //    "Hello World",
            //    "Immutable",
            //    "Scope Resolution Operator",
            //    "Dude"
            //};

            Random generator = new Random();
            int index = generator.Next(secrets.Length);

            secret = secrets[index].ToLower();
        }

        // Build the initial revealed secret
        // hello world => _ _ _ _ _   _ _ _ _ _
        static void BuildInitialRevealedSecret()
        {
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == ' ')
                {
                    revealedSecret += "  ";
                }
                else
                {
                    revealedSecret += "_ ";
                }
            }
        }

        // Requesting a letter from the user
        static char RequestLetterFromUser()
        {
            // Keep asking for valid lowercased letter
            char letter = ' ';
            do
            {
                Console.Write("Please enter your guess (single letter): ");

                // Long version:
                string input = Console.ReadLine();      // Read letter
                input = input.ToLower();                // Lowercase
                letter = Convert.ToChar(input[0]);         // String to single char

                // Short version:
                // letter = Convert.ToChar(Console.ReadLine().ToLower()[0]);
            } while (!(letter >= 'a' && letter <= 'z'));

            return letter;
        }

        // Process the user letter
        static void ProcessUserLetter(char letter)
        {
            // Check if already tried
            if (previouslyGuessedLetters.Contains(letter))
            {
                Console.WriteLine("You already tried that letter");
            }
            else
            {
                previouslyGuessedLetters += $"{letter} ";
                if (secret.Contains(letter))
                {
                    Console.WriteLine("You guessed correct!");

                    string newRevealedSecret = "";
                    for (int i = 0; i < secret.Length; i++)
                    {
                        if (secret[i] == letter)
                        {
                            newRevealedSecret += $"{letter} ";
                        }
                        else
                        {
                            newRevealedSecret += $"{revealedSecret[2 * i]} ";
                        }
                    }

                    revealedSecret = newRevealedSecret;
                }
                else
                {
                    Console.WriteLine("Wrong guess. Getting closer to the gallows");
                    remainingTries--;
                }
            }
        }

        static void GameLoop()
        {
            do
            {
                // Print revealed secret
                Console.WriteLine($"Current user progress: {revealedSecret}");

                // Show previous guesses and number of tries left
                Console.WriteLine($"You tried the following letters: {previouslyGuessedLetters}");
                Console.WriteLine($"You have {remainingTries} wrong guesses left");

                // Get a guess from the user and save in variable
                char userGuess = RequestLetterFromUser();
                Console.WriteLine("Your guess: " + userGuess);

                // Process the letter from the user
                ProcessUserLetter(userGuess);
                Console.Clear();
            } while (revealedSecret.Contains("_") && remainingTries > 0);
        }

        static void DetermineWinLoss()
        {
            if (remainingTries != 0)
            {
                Console.WriteLine("\nYou have won the game. Congratz.");
            }
            else
            {
                Console.WriteLine("\nAah you lost from the best. Gallows for u");
                Console.WriteLine($"The secret was {secret}");
            }

            Console.WriteLine("\n\nThank you for playing Hangman");
        }

        static void Main(string[] args)
        {
            Welcome();
            GenerateSecret();
            BuildInitialRevealedSecret();
            GameLoop();
            DetermineWinLoss();
        }
    }
}
