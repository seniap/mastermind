namespace Mastermind;

public class Codemaker
{
    public List<int> SecretCode()
    {
        var secretCode = new List<int>();
        var random = new Random();
        for (var i = 0; i < GameRules.CodeLength; i++)
        {
            secretCode.Add(random.Next(1, 7));
        }
        // Console.WriteLine(string.Join("", secretCode.ToArray()));

        return secretCode;
    }
}
