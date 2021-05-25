using System;

Console.Clear();
main();


void main()
{
    int guesses = 0;
    Console.WriteLine("Hey! Guess my secret number?");
    Random i = new Random();
    int correctnumber = i.Next(0,100);
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Hey! Guess my secret number?");
        int guessnum = guess(guesses);
        

        if (guessnum == correctnumber)
        {
            Console.Write("You guessed Correctly!");
            return;
        }

        else if (guessnum < correctnumber)
        {
            guesses++;
            Console.WriteLine("Your Guess was too low");
            Console.WriteLine($"You have {4-guesses} guesses left...");
             System.Threading.Thread.Sleep(3000);
        }
        else 
        {
            guesses++;
            Console.WriteLine("Your Guess was too high");
            Console.WriteLine($"You have {4-guesses} guesses left...");
            System.Threading.Thread.Sleep(3000);
        }

        if (guesses == 4)
        {
            Console.WriteLine("You lose!!!");
            Console.WriteLine($"The correct number was {correctnumber}");
            return;
        }

    }
}

int guess(int trynumber)
{
    while (true)
    {
        Console.Write($"Your guess ({trynumber})? ");
        string guess = Console.ReadLine();
        ;
        if (int.TryParse(guess, out int guessnum))
        {
            return guessnum;
        }
    }
}




