# Rock Paper Scissors Game
This is a simple implementation of the classic Rock, Paper, Scissors game in C#. The game allows a player to compete against the computer, with the option to play multiple rounds until the player decides to quit.

## Prerequisites
- <a href="https://code.visualstudio.com">Visual Studio Code</a> or <a href="https://visualstudio.microsoft.com/pt-br/">Visual Studio</a>
- <a href="https://dotnet.microsoft.com/pt-br/download">.NET SDK</a>
  
## Setup Instructions
### Using Visual Studio Code
1. Ensure you have the <a href="https://dotnet.microsoft.com/pt-br/download">.NET SDK</a> installed on your computer.
2. Install the <a href="https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp">C# extension for Visual Studio Code</a>.
3.  Clone the repository to your local machine:
  `git clone https://github.com/LeRodrigues2005/RockPaperScissors.git`
5. Open the cloned repository folder in Visual Studio Code.
6.  Open the terminal in Visual Studio Code and navigate to the project directory.
7.  Run the following command to build and run the program:
  `dotnet run`

### Using Visual Studio
1. Ensure you have the <a href="https://visualstudio.microsoft.com/pt-br/">Visual Studio</a> installed with the .NET desktop development workload.
2. Clone the repository to your local machine:
  `git clone https://github.com/LeRodrigues2005/RockPaperScissors.git`
3. Open the cloned repository folder in Visual Studio.
4.  Build and run the program by pressing `Ctrl + F5` or by clicking on ***Run*** in the menu.
   
## How to Play
1. The game will prompt you to choose between ROCK, PAPER, or SCISSORS.
2. Type your choice and press Enter.
3. The computer will randomly select its choice.
4. The result of the game (win, lose, or draw) will be displayed.
5. You will be asked if you want to play again. Type Y to play another round or N to quit the game.
   
### Code Explanation
The main logic of the game is implemented in the Program class. Here's a brief overview:

1. The Main method initializes the game, including a Random object to generate the computer's choice and a playAgain flag to control the game loop.
2. The game runs in a loop, asking the player for their choice and validating it.
3. The computer's choice is generated randomly.
4. The player's and computer's choices are compared to determine the outcome (win, lose, or draw).
5. The player is then asked if they want to play again.

### Example Output
![image](https://github.com/LeRodrigues2005/RockPaperScissors/assets/97632543/fe1fda59-8ce3-4700-8742-057dcb22d06f)
### Note
You may see the following warning: `warning CS8602: Dereference of a possibly null reference.`
However, this will not prevent the game from running correctly.

### Acknowledgements
This game was created using Visual Studio Code. Special thanks to the C# community for their helpful resources and documentation.

