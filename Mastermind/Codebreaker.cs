namespace Mastermind;

public class Codebraker
{
    public List<string> GetUserInput()
    {
        Console.WriteLine($"Enter a {GameRules.CodeLength}-digit code using numbers from 1 to 6, numbers may be repeated:");

        var userInputStr = Console.ReadLine() ?? string.Empty;

        userInputStr = userInputStr.Trim();
        userInputStr = userInputStr.PadRight(GameRules.CodeLength, '_');
        userInputStr = userInputStr[..GameRules.CodeLength];

        return userInputStr.Select(ch => ch.ToString()).ToList();
    }
}