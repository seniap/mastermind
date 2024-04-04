namespace Mastermind;

class Program
{
    static void Main()
    {
        var theGame = new TheGame();

        theGame.StartGame();
        
        while (theGame.IsPlaying()) 
        {
            theGame.AskPlayer();
        }


        // Console.WriteLine("      \\");
        // Console.WriteLine("*//////{<>==================-");
        // Console.WriteLine("      /");
        // Console.WriteLine("==============================");
        // Console.WriteLine("WELCOME TO MASTERMIND GAME!");
        // Console.WriteLine("==============================");
        // Console.WriteLine();
        // Console.WriteLine($"Try to break my code: {string.Empty.PadLeft(GameRules.CodeLength, '*')}");
        // Console.WriteLine();

        // var newGame = new Codemaker();
        // var newBrakeAttempt = new Codebraker();
        // var newFeedback = new Feedback();
        
        // var newSecretCode = newGame.SecretCode();

        // var playedGames = 0;
        // bool playGame;
        
        // do
        // {
        //     Console.WriteLine($"Enter a {GameRules.CodeLength}-digit code using numbers from 1 to 6, numbers may be repeated.");
        //     Console.WriteLine($"Number of attempts left: {GameRules.MaxAttempts - playedGames}");
        //     Console.WriteLine();
        //     var newInput = newBrakeAttempt.GetUserInput();
        //     playGame = newFeedback.GuessFeedback(newSecretCode, newInput, out int correctValNum, out int correctIndxNum, out List<char> inputFeedback);
        //     if (!playGame)
        //     {
        //         Console.WriteLine("------------------------------");
        //         Console.WriteLine("CONGRATULATIONS! YOU WON!");
        //         break;
        //     }
        //     Console.WriteLine();
        //     Console.WriteLine($"Numbers guessed correctly: {correctValNum} out of {GameRules.CodeLength}. Numbers in correct position: {correctIndxNum}.");
        //     Console.WriteLine("Visual feedback is given in following order:");
        //     Console.WriteLine("V - amount of correctly guessed numbers in correct position");
        //     Console.WriteLine("X - amount of correctly guessed numbers NOT in correct position");
        //     Console.WriteLine(". - amount of incorrectly guessed numbers");
        //     Console.WriteLine();
        //     Console.WriteLine(inputFeedback.ItemsToString());
        //     Console.WriteLine("------------------------------");
        //     playedGames++;
        // }
        // while (playGame && playedGames < GameRules.MaxAttempts);

        // if (playedGames >= GameRules.MaxAttempts)
        // {
        //     Console.WriteLine($"You've runned out of attempts. The code is: {newSecretCode.ItemsToString()}");
        //     Console.WriteLine("GAME OVER");
        // }
    }
}
