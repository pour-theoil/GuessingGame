using System;

Console.Clear();
main();


void main()
{
    int guesses = 0;
    while (true)
    {

        
        Console.WriteLine("Hey! Guess my secret number?");

        int guessnum = guess();
        int correctnumber = 42;

        if (guessnum == correctnumber)
        {
            Console.Write("You guessed Correctly!");
            return;
        }

        else
        {
            Console.WriteLine("You guessed wrong...");
            guesses++;
        }

        if (guesses == 4)
        {
            Console.WriteLine("You lose!!!");
            return;
        }

    }
}

int guess()
{
    while (true)
    {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        ;
        if (int.TryParse(guess, out int guessnum))
        {
            return guessnum;
        }
    }
}




