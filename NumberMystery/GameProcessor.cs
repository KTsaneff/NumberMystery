using System.Runtime.CompilerServices;

namespace NumberMystery
{
    public class GameProcessor
    {
        private int level;
        private string playerName;

        public GameProcessor()
        {
            this.Level = 0;
            this.PlayerName = playerName;
        }

        public int Level 
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            } 
        }

        public string PlayerName 
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            } 
        }

        public void ResetLevel()
        {
            this.Level = 1;
        }

        public void RangeInstruction()
        {
            Console.Write($"Guess a number (1 -> {this.Level*100}): ");
        }

        public int SetLevel()
        {           
            this.Level++;

            Random levelRange = new();
                int newLevel = levelRange.Next(1, this.level*100 + 1);

            Console.WriteLine($"Level {this.Level}");

            return newLevel;
        }
        public void WelcomeGreeting()
        {
            Console.WriteLine("Welcome to Number Mystery!");
            Thread.Sleep(1000);
            Console.Write("Enter Your name here: ");
            this.PlayerName = Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Hello, {this.PlayerName}!");
            Thread.Sleep(1200);
            Console.WriteLine("You will have limited number of tries to guess a number in a specific range, good luck!");
            Thread.Sleep(2000);
        }

        public void GameOver()
        {
            Console.WriteLine("Game over!");
            Environment.Exit(0);
        }

        public bool ContinueGame()
        {
            Console.WriteLine("One more game Yes/No ?");
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Yes")
                {
                    return true;
                }
                else if (input == "No")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                    input = Console.ReadLine();
                }
            }
        }

        public int DufficultySelector()
        {
            Console.WriteLine("Please select your Difficulty Level from the following options: Beginner / Medium / Expert");
            string difficulty = Console.ReadLine();
            int difficultyLevel;
            while (true)
            {
                if (difficulty == "Beginner")
                {
                    difficultyLevel = 10;
                    break;
                }
                else if (difficulty == "Medium")
                {
                    difficultyLevel = 8;
                    break;
                }
                else if (difficulty == "Expert")
                {
                    difficultyLevel = 6;
                    break;
                }
                else
                {
                    Console.WriteLine("Error! You can choose from the following options: Beginner / Medium / Expert");
                    difficulty = Console.ReadLine();
                }
            }

            Console.WriteLine($"You have selected {difficulty}. You will have {difficultyLevel} tries.");
            Thread.Sleep(1300);
            return difficultyLevel;
        }
    }
}
