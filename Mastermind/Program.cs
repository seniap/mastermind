namespace Mastermind;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Mastermind game!");
        Console.WriteLine($"Try to break my code: {string.Empty.PadLeft(GameRules.CodeLength, 'X')}");

        var newGame = new Codemaker();
        var newBrakeAttempt = new Codebraker();
        var newFeedback = new Feedback();
        
        var newSecretCode = newGame.SecretCode();

        var playedGames = 0;
        bool playGame;
        do
        {
            var newInput = newBrakeAttempt.GetUserInput();
            playGame = newFeedback.GuessFeedback(newSecretCode, newInput);
            playedGames++;
        }
        while (playGame && playedGames <= GameRules.MaxAttempts);

        if (playedGames > GameRules.MaxAttempts)
        {
            Console.WriteLine($"You've runned out of attempts. the code is: {newSecretCode.ItemsToString()}");
            Console.WriteLine("GAME OVER");
        }
    }
}
