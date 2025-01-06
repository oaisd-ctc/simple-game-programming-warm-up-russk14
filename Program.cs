using System;

public class Program
{


    public static void Main(string[] args)
    {
        Intro();
        int wins = 0;
        int losses = 0;

        for (int i = 1; i <= 10; i++)
        {
            int rivalNum = Rng();
            int playerNum = Rng();


            Console.WriteLine($"Round {i}");
            Console.WriteLine($"Rival rolled a {rivalNum}");
            Console.WriteLine($"Press any key to roll the dice...");
            Console.ReadKey();
            Console.WriteLine($"You rolled a {playerNum}");

            if (rivalNum > playerNum)
            {
                Console.WriteLine("The Rival won this round.");
                wins += 1;
            }
            else if (playerNum > rivalNum)
            {
                Console.WriteLine("You won this round.");
                losses += 1;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }

            Console.WriteLine($"The score is now - You: {wins}. Rival: {losses}.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You: {wins}. Rival : {losses}.");
        if (wins > losses){
            Console.WriteLine("You won!");
        } else if (losses > wins){
            Console.WriteLine("You lost.");
        } else {
            Console.WriteLine("This game is a draw.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }

    public static void Intro()
    {
        Console.WriteLine("In this game you and a computer rival will play 10 rounds\nwhere you will each roll a 6-sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.WriteLine();
    }

    public static int Rng()
    {
        Random RNGobject = new Random();
        int num = RNGobject.Next(1, 7);
        return num;
    }

}