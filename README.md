# Guess The Number Game

This project is a console-based **Guess The Number** game written in C#. It offers an interactive way for players to test their guessing skills with helpful hints provided during gameplay.

## Features

1. **Random Number Generation**:
   - A random number between 1 and 1000 is generated at the start of the game.
   - Ensures that each game session is unique.

2. **User-Friendly Gameplay**:
   - Users can exit the game anytime by pressing `0`.
   - Input validation ensures only valid numbers are accepted.

3. **Hints for Players**:
   - When a guess is incorrect, the program provides a hint:
     - "Guess a higher number!" if the guess is too low.
     - "Guess a lower number!" if the guess is too high.

4. **Tracking Attempts**:
   - Displays the total number of attempts once the correct number is guessed.

5. **Modular Design**:
   - `StartGame()`: Manages the core game logic and validates user input.
   - `GiveHint()`: Provides helpful hints to guide the player.
   - `Main()`: Initiates the game and handles user input for starting or exiting.

## How to Play

1. Run the program from the console.
2. The game generates a random number between 1 and 1000.
3. Players try to guess the number. For every wrong guess:
   - A hint is provided to guess higher or lower.
4. Once the correct number is guessed, the program displays:
   - The correct number.
   - The total number of attempts made.

5. Press `0` at the start to exit the game if desired.

## Sample Output

### Example 1:
