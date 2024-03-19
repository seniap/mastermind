namespace Mastermind;

public class Feedback
{
    private readonly MatchCounter _matchCounter = new();
    private const char CorrectVal = 'X';
    private const char CorrectIndx = 'V';
    private const char DefaultCh = '.';

    public bool GuessFeedback(List<string> code, List<string> input)
    {
        if (input.ItemsToString() == code.ItemsToString())
        {
            Console.WriteLine("Congratulations! You won!");

            return false;
        }

        var matchingIntCode = _matchCounter.CountMatches(code);
        var matchingIntInput = _matchCounter.CountMatches(input);

        var feedback = new List<char>();

        for (var i = 0; i < input.Count; i++)
        {
            if (input[i] == code[i])
            {
                feedback.Add(CorrectIndx);
            }
            else if (code.Contains(input[i]) &&
                matchingIntCode[Int32.Parse(input[i]) - 1] >= matchingIntInput[Int32.Parse(input[i]) - 1])
            {
                feedback.Add(CorrectVal);
            }
            else
            {
                feedback.Add(DefaultCh);
            }
        }

        var shuffledFeedback = ShuffleFeedback(feedback);

        var shuffledFeedbackStr = shuffledFeedback.ItemsToString();

        Console.WriteLine(shuffledFeedbackStr);

        return true;
    }

    private List<char> ShuffleFeedback(List<char> items)
    {
        return items.OrderBy(x => Random.Shared.Next()).ToList();
    }
}
