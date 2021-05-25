using System;

Console.Clear();
main();


void main()
{
    int guesses = 0;
    Console.WriteLine("Hey! Guess my secret number?");
    Random i = new Random();
    int correctnumber = i.Next(0,100);

    int[] levels = {8, 6, 4};
    int choice = difficulty();
    int difficultylevel = levels[choice -1];

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
            Console.WriteLine($"You have {difficultylevel-guesses} guesses left...");
             System.Threading.Thread.Sleep(3000);
        }
        else 
        {
            guesses++;
            Console.WriteLine("Your Guess was too high");
            Console.WriteLine($"You have {difficultylevel-guesses} guesses left...");
            System.Threading.Thread.Sleep(2000);
        }

        if (guesses == difficultylevel)
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

int difficulty()
{
    while (true)
    {
        Console.Write(@"
What difficulty would you like to play?
1) Easy (eight guesses)
2) Medium (six guesses)
3) Hard (this gives the user four guesses)
");


        string choice = Console.ReadLine();
        ;
        if (int.TryParse(choice, out int choicenum))
        {
            return choicenum;
        }
    }
}


