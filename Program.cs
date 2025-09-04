internal class Program
{   


    static Random rmg = new Random();
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************");
        Console.WriteLine("Welcome to Hang Man Game..!");
        Console.WriteLine("***************************");
        
        
        startGame();

         // Adding a Comment

        // Adding  anthoer comment
    }

 
    // Start Game Method
    static void startGame()
    {
        List<string> wordList = new List<string>() { "computer", "programming", "hangman", "challenge", "developer" };
        string selectedWord = wordList[rmg.Next(wordList.Count)];
        int nbrofGuesses = 6;
        Console.WriteLine("Let's Start the Game!");
        Console.WriteLine("You have 6 tries to guess the Word! ");
        Console.WriteLine("Good Luck!");
        Console.WriteLine("The word has " + selectedWord.Length + " letters.");
        Console.WriteLine("You can start guessing now.");

        // Displaying underscores for the word
        char[] guessedLetters = new char[selectedWord.Length];
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            guessedLetters[i] = '_';
        }
        Console.WriteLine(string.Join(" ", guessedLetters));

        // Game Loop
        while (nbrofGuesses > 0)
        {
            Console.Write("Enter a letter: ");
            char guessedLetter = Console.ReadLine()[0];
            bool isCorrectGuess = false;
  
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guessedLetter)
                {
                    guessedLetters[i] = guessedLetter;
                    isCorrectGuess = true;
                }
            }
            if (!isCorrectGuess)
            {
                nbrofGuesses--;
                Console.WriteLine("Wrong guess! You have " + nbrofGuesses + " tries left.");

                if (nbrofGuesses == 0)
                {
                    Console.WriteLine("Game Over! The word was: " + selectedWord);
                  
                }
            }
            else
            {
                Console.WriteLine("Good guess!");
            }

        
            Console.WriteLine(string.Join(" ", guessedLetters));
            if (!guessedLetters.Contains('_'))
            {
                Console.WriteLine("Congratulations! You've guessed the word: " + selectedWord);
                return;
            }
        }






        
    }
}