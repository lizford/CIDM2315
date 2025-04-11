namespace MidtermBonus;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        // Create player objects: human and computer
        HumanPlayer humanPlayer = new HumanPlayer(5); // Initial points set to 5
        ComputerPlayer computerPlayer = new ComputerPlayer();

        while (true)
        {
            Console.Clear();

            // Display current points of the human player
            Console.WriteLine("Human Player's Points: " + humanPlayer.GetPoints());

            // Exit the game if the human player has 0 points
            if (humanPlayer.GetPoints() <= 0)
            {
                Console.WriteLine("Game Over! You have no points left.");
                break;
            }

            // Get the human player's decision
            string humanChoice = humanPlayer.HumanDecision();

            // Get the computer's decision
            string computerChoice = computerPlayer.ComputerDecision();

            // Display choices
            Console.WriteLine("You chose: " + humanChoice);
            Console.WriteLine("Computer chose: " + computerChoice);

            // Determine the outcome of the round
            if (humanChoice == computerChoice)
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }
            else if ((humanChoice == "rock" && computerChoice == "scissors") ||
                     (humanChoice == "paper" && computerChoice == "rock") ||
                     (humanChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win this round!");
                humanPlayer.WinRound(); // Increase points by 5
            }
            else
            {
                Console.WriteLine("You lose this round.");
                humanPlayer.LoseRound(); // Decrease points by 5
            }

            // Ask if the player wants to continue or exit the game
            Console.WriteLine("\nDo you want to play another round? (y/n): ");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain != "y")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }   
    }   
}



        class HumanPlayer
{
    private int points; // the points that the human player has

    // Constructor used to set human player's initial points
    public HumanPlayer(int initial)
    {
        points = initial;
    }

    // Returns the points of the human player
    public int GetPoints()
    {
        return points;
    }

    // Human player wins a round and increases 5 points
    public void WinRound()
    {
        points += 5;
    }

    // Human player loses a round and decreases 5 points
    public void LoseRound()
    {
        points -= 5;
    }

    // Human player selects a shape (Rock, Paper, or Scissors)
    public string HumanDecision()
    {
        Console.WriteLine("Enter your choice (Rock, Paper, or Scissors): ");
        string decision = Console.ReadLine().ToLower();

        // Validate the user's input
        while (decision != "rock" && decision != "paper" && decision != "scissors")
        {
            Console.WriteLine("Invalid input! Please enter Rock, Paper, or Scissors: ");
            decision = Console.ReadLine().ToLower();
        }
        return decision;
    }
}



    class ComputerPlayer
{
    private static Random random = new Random();

    // Computer player randomly picks a shape (Rock, Paper, or Scissors)
    public string ComputerDecision()
    {
        int choice = random.Next(0, 3); // Random number between 0 and 2
        switch (choice)
        {
            case 0: return "rock";
            case 1: return "paper";
            case 2: return "scissors";
            default: return "rock"; // Default fallback, though it shouldn't be reached
        }
    }
}
