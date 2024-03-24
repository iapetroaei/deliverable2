using System;

public class Program
{
    public static void Main()
    {

	// Header to welcome the player.

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!\n");
        
        // Ask for player name.

        Console.Write("What is your name?\n");

		//Read response and store as string for use.
		
        string name = Console.ReadLine();
 
		//Welcome player using the input provided and ask tif they want to play a game.
		
		Console.WriteLine("Welcome " + name + ", Do you want to do the COIN FLIP CHALLENGE? (Yes/No)");
		
		//same as before store the choice of the player.
		
        string choice = Console.ReadLine();

        // Check players choice. tolower is used to normalize the answer and bring it in line with programmed value.

        if (choice.ToLower() == "no")
        {
            Console.WriteLine("You are a coward " + name + "!");
            return;
        }
        else if (choice.ToLower() != "yes")
        {
            Console.WriteLine("Invalid choice! Ending the program.");
            return;
        }

        // Defining score variable as an int.
		
        int score = 0;

        // creating parameters for the game to last 5 rounds.
		
        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine("\nRound "+ round);
            
            // Generate a random number (0 or 1) 
			
            Random random = new Random();
            int randomNumber = random.Next(2); 
            
            // Ask user to guess heads or tails
			
            Console.Write("Heads or Tails? ");
			
            string guess = Console.ReadLine().ToLower();
            
            // Compare user's guess with the randomly generated number
            string result = (randomNumber == 0) ? "heads" : "tails";

            // Check if the player guess is correct.
			
            if (guess == result)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        // Display the final score to the player.
		
        Console.WriteLine("\nThank you " +name + ". You got a score of " + score + "!");
    }
}