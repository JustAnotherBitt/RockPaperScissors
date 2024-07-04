class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;
        
        while(playAgain)
        {
            player = "";
            computer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Chose ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine().ToUpper();
            }

            switch(random.Next(1,4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }

            Console.WriteLine("Computer: " + computer);
            Console.WriteLine("Player: " + player);
            
            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                        Console.WriteLine("It's a draw!");
                
                    else if (computer == "PAPER")  
                        Console.WriteLine("You lose!");
                        
                    else                       
                        Console.WriteLine("You win!");
                    break;

                case "PAPER":
                    if (computer == "ROCK")
                        Console.WriteLine("You win!");
                
                    else if (computer == "PAPER")  
                        Console.WriteLine("It's a draw!");

                    else                       
                        Console.WriteLine("You lose!");
                    break;

                case "SCISSORS":
                    if (computer == "ROCK")
                        Console.WriteLine("You lose!");
                
                    else if (computer == "PAPER")  
                        Console.WriteLine("You win!");

                    else                       
                        Console.WriteLine("It's a draw!");      
                    break;                     
            }

            Console.WriteLine("Do you want to play again? (Y/N)");
            answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
                playAgain = true;
            else if (answer == "N")
                playAgain = false;
            else               
                Console.WriteLine("Sorry, I didn't understand you, so I'll leave you alone.");
                playAgain = false;
        }
        Console.WriteLine("Thanks for playing!!");
    }
}
