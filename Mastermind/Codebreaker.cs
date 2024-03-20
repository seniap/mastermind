namespace Mastermind;

public class Codebraker
{
    public List<string> GetUserInput()
    {
        var userInputStr = Console.ReadLine() ?? string.Empty;

        userInputStr = userInputStr.Trim();
        userInputStr = userInputStr.PadRight(GameRules.CodeLength, '_');
        userInputStr = userInputStr[..GameRules.CodeLength];

        return userInputStr.Select(ch => ch.ToString()).ToList();
    }
}