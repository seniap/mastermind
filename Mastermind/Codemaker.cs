using Mastermind.Interfaces;

namespace Mastermind;

public class Codemaker : ICodemaker
{
    private readonly List<string> _secretCodeSymbols = ["1", "2", "3", "4", "5", "6"];

    public List<string> CreateSecretCode()
    {
        var secretCode = new List<string>();
        var random = new Random();
        for (var i = 0; i < GameRules.CodeLength; i++)
        {
            secretCode.Add(_secretCodeSymbols[random.Next(0, 6)]);
        }

        // Console.WriteLine(secretCode.ItemsToString());

        return secretCode;
    }
}
