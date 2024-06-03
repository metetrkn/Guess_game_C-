# Gissa Talet (Guess the Number)

This is a simple console-based game where the player attempts to guess a randomly generated number between 1 and 100. The player has up to 10 attempts to guess the correct number. After each game, the player can choose to play again. The game keeps track of the number of attempts taken to guess correctly and displays the record for the fewest attempts at the end.

## Features

- Randomly generates a number between 1 and 100.
- Allows the player up to 10 attempts to guess the number.
- Provides feedback on whether the guess is too high or too low.
- Indicates if the guess is very close (within 10 numbers).
- Allows the player to play multiple rounds.
- Tracks the best score (minimum number of guesses to find the number).

## Instructions

1. **Run the Program**: Start the program by executing the compiled executable in a console window.
2. **Gameplay**:
    - The game will prompt you to guess a number between 1 and 100.
    - Type your guess and press Enter.
    - The game will provide feedback on whether your guess is too high, too low, or correct.
    - If your guess is incorrect, you will be informed if you are close (within 10 numbers).
    - You have up to 10 attempts to guess the correct number.
    - If you guess the number correctly, the game will display the number of attempts it took.
    - If you run out of attempts, the game will reveal the correct number.
3. **Play Again**: After each round, you can choose to play again by typing 'p' or exit by typing any other key.
4. **Record**: At the end of your session, the game will display the record for the fewest number of attempts needed to guess the number correctly.

## Code Overview

- **Namespace**: `Uppgift1`
- **Class**: `Program1`
- **Main Method**: Contains the game loop and logic for guessing the number.
- **Random Number Generation**: Utilizes the `Random` class to generate a number between 1 and 100.
- **User Input**: Reads the user's guesses and provides feedback.
- **Game Loop**: Allows the game to continue running until the player chooses to stop.
- **Record Keeping**: Tracks the number of guesses per game and determines the minimum number of guesses for a correct answer.

## Dependencies

- .NET Framework (version compatible with the code, typically .NET Core or .NET 5 and above).

## How to Run

1. **Clone the Repository**:
   ```sh
   git clone <repository-url>

2. **Navigate to the Project Directory**:
   ```sh
   cd <project-directory>

3. **Build the project**:
   ```sh
   dotnet build

4. **Run the Project:**:
   ```sh
   dotnet run

## Example Output
   ```sh
   Gissa talet
   Du ska nu gissa ett tal mellan 1 och 100, så varsågod..
   Skriv in ett tal
   The program will then provide feedback based on the player's input.
