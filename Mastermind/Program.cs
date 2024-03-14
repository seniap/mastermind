namespace Mastermind
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Mastermind game!");
            Console.WriteLine("Try to break my code: XXXX");

            var newGame = new Codemaker();
            var newSecretCode = newGame.SecretCode();
            var newBrakeAttempt = new Codebraker();
            var newInput = newBrakeAttempt.UserInput();
            var newFeedback = new Feedback();
            var playGame = newFeedback.GuessFeedback(newSecretCode, newInput);
            var playedGames = 1;

            while (playGame && playedGames < 10)
            {
                playedGames++;
                newInput = newBrakeAttempt.UserInput();
                playGame = newFeedback.GuessFeedback(newSecretCode, newInput);
            }

            if (playedGames >= 10)
            {
                Console.WriteLine($"You've runned out of attempts. the code is: {string.Join( "", newSecretCode.ToArray())}");
                Console.WriteLine("GAME OVER");
            }
        }
    }
}
