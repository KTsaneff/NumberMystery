using System.Runtime.CompilerServices;

namespace NumberMystery
{
    public class GameProcessor
    {
        private int level;

        public GameProcessor()
        {
            this.Level = 0;
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
            Thread.Sleep(1200);
            Console.WriteLine("You will have 8 tries to guess a number in a specific range, good luck!");
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
    }
}
