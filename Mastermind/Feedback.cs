namespace Mastermind;

public class Feedback
{
    private const char CorrectIndx = 'V';
    private const char CorrectVal = 'X';
    private const char DefaultCh = '.';

    public bool GuessFeedback(List<string> code, List<string> input)
    {
        if (input.ItemsToString() == code.ItemsToString())
        {
            Console.WriteLine("Congratulations! You won!");

            return false;
        }

        var correctIndxNum = 0;
        var correctValNum = 0;
        var codeFeedback = new List<string>(code);
        var inputFeedback = new List<char>();

        for (var i = 0; i < input.Count; i++)
        {
            if (input[i] == code[i])
            {
                correctIndxNum++;
            }
        }

        for (var i = 0; i < input.Count; i++)
        {
            if (codeFeedback.Contains(input[i]))
            {
                codeFeedback.Remove(input[i]);
                correctValNum++;
            }
        }

        inputFeedback.AddRange(Enumerable.Repeat(CorrectIndx, correctIndxNum));
        inputFeedback.AddRange(Enumerable.Repeat(CorrectVal, correctValNum - correctIndxNum));
        inputFeedback.AddRange(Enumerable.Repeat(DefaultCh, GameRules.CodeLength - correctValNum));

        Console.WriteLine(inputFeedback.ItemsToString());

        return true;
    }
}
