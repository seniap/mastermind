namespace Mastermind.Interfaces;

public interface IFeedback
{
    bool GuessFeedback(List<string> code, List<string> input, out int correctValNum, out int correctIndxNum, out List<char> inputFeedback);
}
