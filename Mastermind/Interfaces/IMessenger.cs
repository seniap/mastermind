namespace Mastermind.Interfaces;

public interface IMessenger
{
    void GreetPlayer();
    void StartGame();
    void AskForInput(int playedGames);
    void SayWin();
    void SayFeedback(int correctValNum, int correctIndxNum, List<char> inputFeedback);
    void SayLose(List<string> newSecretCode);
    void AskToPlayAgain();
}
