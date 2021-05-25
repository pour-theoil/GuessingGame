using System;

main();

void main()
{
    
        Console.WriteLine("Hey! Guess my secret number?");
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int correctnumber = 42;

        if (int.TryParse(guess, out int guessnum))
        {
            if (guessnum == correctnumber)
            {
                Console.Write("You guessed Correctly!");
            }
            else
            {
                Console.WriteLine("You guessed wrong...");
            }
        }
    
}






