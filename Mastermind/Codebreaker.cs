using Mastermind.Interfaces;

namespace Mastermind;

public class Codebraker : ICodebraker
{
    public List<string> GetUserInput()
    {
        var userInputStr = CodeHelperExtensions.TakeUserInput();

        userInputStr = userInputStr.PadRight(GameRules.CodeLength, '_');
        userInputStr = userInputStr[..GameRules.CodeLength];

        return userInputStr.Select(ch => ch.ToString()).ToList();
    }
}