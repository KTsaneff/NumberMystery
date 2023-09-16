namespace NumberMystery
{
    public class GameProcessor
    {
        public static void GameOver()
        {
            Console.WriteLine("Game over!");
            Environment.Exit(0);
        }

        public static bool ContinueGame()
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
