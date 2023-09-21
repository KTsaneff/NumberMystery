# The "Number Mystery" Game
This is a simple console game built for edicational purposes.
The project is originally created by SoftUni.

## Table of Contents

- [Getting Started](#getting-started)
- [Game Rules](#game-rules)
- [How to Play](#how-to-play)
- [Game Processor](#game-processor)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get started with the **"Number Mystery"** game, follow these steps:

1.Clone this repository to your local machine:
  https://github.com/KTsaneff/NumberMystery.git

2. Navigate to the project directory:
  cd _NumberMystery_

3. Build and Run the game using C#:
  dotnet build
  dotnet run

## Game Rules

The game follows these simple rules:

- The computer generates a random number between 1 and 100.
- The player's task is to guess the generated number.
- The player has a limited number of attempts, depending on the difficulty level chosen, to guess the correct number.
- After each guess, the game provides feedback on whether the guess is too high of too low.
- The player will receive warning after the seventh attempt, that there is only one attempt left.
- The player wins if they correctly guess the number within the allowed attempts.
- If the player successfully guesses the number, the game has an option to be continued on the next level, where the range will be increased by 100 (1 -200).

## How to Play

1. Launch the game by running the `dotnet run` command in the project directory.
2. The `StartUp` class handles the game's logic and user interaction.
3. You will be prompted to enter your name and choose the difficulty level (Beginner, Medium, or Expert).
4. The game will use the `GameProcessor` class to manage the game's logic and range level.
5. Start guessing the number as instructed.
6. The `GameProcessor` class handles displaying instructions, managing levels, and determining if the game is over or if the player wants to play again.
7. Once the game ends, you will be informed whether you won or lost, and you can choose to play again.

## Game Processor

The `GameProcessor` class plays a crucial role in managing the game's logic. Here's an overview of its methods and properties:

- `ResetLevel()`: Resets the game level to 1.
- `RangeInstruction()`: Displays instructions for the current game level's number range.
- `SetLevel()`: Increments the game level and returns a random number within the new level's range.
- `WelcomeGreeting()`: Displays a welcome message, collects the player's name, and provides instructions.
- `GameOver()`: Exits the game when called, indicating that it's over.
- `ContinueGame()`: Asks the player if they want to play another round and handles their response.
- `DifficultySelector()`: Allows the player to choose the game's difficulty level (Beginner, Medium, or Expert) and returns the allowed number of tries.

## Contributing

Contributions to this educational project are welcome! If you'd like to improve the game, add new features, or enhance the `GameProcessor` class or `StartUp` class, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and test them thoroughly.
4. Submit a pull request explaining your changes and why they are beneficial.

## License

This project is licensed under the [MIT License](LICENSE.md). Feel free to use, modify, and distribute it for educational purposes.

Happy coding and have fun learning!
