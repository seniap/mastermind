namespace Mastermind;

public class TheGame
{
    private Messenger _messenger;
    private Codemaker _codeMaker;
    private Codebraker _codeBreaker;
    private Feedback _feedback;
    private List<string> _secretCode;

    private int _playedGames;
    // private bool _isKeepPlaying;

    public TheGame()
    {
        _messenger = new Messenger();
        _codeMaker = new Codemaker();
        _codeBreaker = new Codebraker();
        _feedback = new Feedback();

        _messenger.GreetPlayer();
    }

    public void StartGame()
    {
        _playedGames = 0;
        _secretCode = _codeMaker.CreateSecretCode();

        _messenger.StartGame();
    }

    /// <summary>
    /// Ask user for the code
    /// </summary>
    public void AskPlayer()
    {
        _playedGames++;
        _messenger.AskForInput(_playedGames);

        var userInput = _codeBreaker.GetUserInput();

        var guessedNotCorrectly = _feedback.GuessFeedback(_secretCode, userInput,
            out var correctValNum, out var correctIndxNum, out var inputFeedback);
    
        if (!guessedNotCorrectly)
        {
            _messenger.SayWin();

            // TODO: Ask if player wants to play again
            StartGame();
            return;
        }

        _messenger.SayFeedback(correctValNum, correctIndxNum, inputFeedback);

        if (!IsPlaying())
        {
            _messenger.SayLose(_secretCode);

            // TODO: Ask if player wants to play again
        }
    }

    public bool IsPlaying()
    {
        return _playedGames <= GameRules.MaxAttempts;
    }
}
