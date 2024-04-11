using Mastermind.Interfaces;

namespace Mastermind;

public class Feedback : IFeedback
{
    private const char CorrectIndx = 'V';
    private const char CorrectVal = 'X';
    private const char DefaultCh = '.';

    public bool GuessFeedback(List<string> code, List<string> input, out int correctValNum, out int correctIndxNum, out List<char> inputFeedback)
    {
        correctIndxNum = 0;
        correctValNum = 0;
        var codeFeedback = new List<string>(code);
        inputFeedback = new List<char>();
        
        if (input.ItemsToString() == code.ItemsToString())
        {
            return false;
        }

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

        return true;
    }
}
