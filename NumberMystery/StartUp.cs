namespace NumberMystery
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write($"Guess a number (1-100): ");
                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playersGuess);

                if (isValid)
                {
                    if (playersGuess == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
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
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}