using Mastermind.Interfaces;

namespace Mastermind;

public class Messenger : IMessenger
{
    public void GreetPlayer()
    {
        Console.WriteLine("      \\");
        Console.WriteLine("*//////{<>==================-");
        Console.WriteLine("      /");
        Console.WriteLine("==============================");
        Console.WriteLine("WELCOME TO MASTERMIND GAME!");
        Console.WriteLine("==============================");
    }

    public void StartGame() 
    {
        Console.WriteLine();
        Console.WriteLine($"Try to break my code: {string.Empty.PadLeft(GameRules.CodeLength, '*')}");
        Console.WriteLine();
    }

    public void AskForInput(int playedGames)
    {
        Console.WriteLine($"Enter a {GameRules.CodeLength}-digit code using numbers from 1 to 6, numbers may be repeated.");
        Console.WriteLine($"Number of attempts left: {GameRules.MaxAttempts - playedGames}");
        Console.WriteLine();
    }

    public void SayWin()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("CONGRATULATIONS! YOU WON!");
    }

    public void SayFeedback(int correctValNum, int correctIndxNum, List<char> inputFeedback)
    {
        Console.WriteLine();
        Console.WriteLine($"Numbers guessed correctly: {correctValNum} out of {GameRules.CodeLength}. Numbers in correct position: {correctIndxNum}.");
        Console.WriteLine("Visual feedback is given in following order:");
        Console.WriteLine("V - amount of correctly guessed numbers in correct position");
        Console.WriteLine("X - amount of correctly guessed numbers NOT in correct position");
        Console.WriteLine(". - amount of incorrectly guessed numbers");
        Console.WriteLine();
        Console.WriteLine(inputFeedback.ItemsToString());
        Console.WriteLine("------------------------------");
    }

    public void SayLose(List<string> newSecretCode)
    {
        Console.WriteLine($"You've runned out of attempts. The code is: {newSecretCode.ItemsToString()}");
        Console.WriteLine("GAME OVER");
    }

    public void AskToPlayAgain()
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to play again? (Y/N)");
    }
}
