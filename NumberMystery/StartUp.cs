namespace NumberMystery
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new();
            int computerNumber = randomNumber.Next(1, 101);

            int allowedTries = 8;

            while (true)
            {
                if (allowedTries == 1)
                {
                    Console.Write("Last chance! ");
                }
                allowedTries--;
                
                Console.Write($"Guess a number (1-100): ");
                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playersGuess);

                if (isValid)
                {
                    if (playersGuess == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");

                        Thread.Sleep(1500);                        

                        bool continueGame = GameProcessor
                            .ContinueGame();                        

                        if(continueGame)
                        {
                            allowedTries = 8;
                            computerNumber = randomNumber.Next(1, 101);
                            continue;
                        }
                        else
                        {
                            GameProcessor.GameOver();
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
                    if (!GameProcessor.ContinueGame())
                    {
                        GameProcessor.GameOver();
                    }
                    allowedTries = 8;
                    continue;
                }
            }
        }
    }
}