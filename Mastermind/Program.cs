namespace Mastermind;

class Program
{
    static void Main()
    {
        var theGame = new TheGame(new Codemaker(), new Codebraker(), new Feedback(), new Messenger());

        theGame.StartGame();
        
        while (theGame.IsPlaying()) 
        {
            theGame.AskPlayer();
        }
    }
}
