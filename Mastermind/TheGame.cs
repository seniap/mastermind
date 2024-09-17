using Mastermind.Interfaces;

namespace Mastermind;

public class TheGame : ITheGame
{
    private readonly ICodemaker _codeMaker;
    private readonly ICodebraker _codeBreaker;
    private readonly IFeedback _feedback;
    private readonly IMessenger _messenger;

    private List<string> _secretCode;

    private int _playedGames;
    // private bool _isKeepPlaying;

    public TheGame(ICodemaker codeMaker, ICodebraker codeBreaker, IFeedback feedback, IMessenger messenger)
    {
        _codeMaker = codeMaker;
        _codeBreaker = codeBreaker;
        _feedback = feedback;
        _messenger = messenger;

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
        _messenger.AskForInput(_playedGames);

        var userInput = _codeBreaker.GetUserInput();

        var guessedNotCorrectly = _feedback.GuessFeedback(_secretCode, userInput,
            out var correctValNum, out var correctIndxNum, out var inputFeedback);
    
        if (!guessedNotCorrectly)
        {
            _messenger.SayWin();

            PlayAgain();
            return;
        }

        _messenger.SayFeedback(correctValNum, correctIndxNum, inputFeedback);

        _playedGames++;

        if (!IsPlaying())
        {
            _messenger.SayLose(_secretCode);

            PlayAgain();
        }
    }

    public bool IsPlaying()
    {
        return _playedGames < GameRules.MaxAttempts;
    }

    private void PlayAgain()
    {
        _messenger.AskToPlayAgain();
        var userAnswer = CodeHelperExtensions.TakeUserInput();

        if (string.Equals(userAnswer, "Y", StringComparison.InvariantCultureIgnoreCase))
        {
            StartGame();
        }
    }
}
