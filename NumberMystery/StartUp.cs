namespace NumberMystery
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            GameProcessor game = new();
            game.WelcomeGreeting();

            int computerNumber = game.SetLevel();

            int allowedTries = 8;

            while (true)
            {
                if (allowedTries == 1)
                {
                    Console.Write("Last chance! ");
                }
                allowedTries--;

                game.RangeInstruction();
                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playersGuess);

                if (isValid)
                {
                    if (playersGuess == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");

                        Thread.Sleep(1500);              

                        bool continueGame = game.ContinueGame();                        

                        if(continueGame)
                        {
                            allowedTries = 8;
                            computerNumber = game.SetLevel();
                            continue;
                        }
                        else
                        {
                            game.GameOver();
                        }
                    }
                    else if (playersGuess > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    allowedTries++;
                    Console.WriteLine("Invalid input.");
                }

                if(allowedTries == 0)
                {
                    Console.WriteLine("You failed!");
                    game.ResetLevel();

                    if (!game.ContinueGame())
                    {
                        game.GameOver();
                    }
                    Console.WriteLine("Level 1");
                    allowedTries = 8;
                    continue;
                }
            }
        }
    }
}