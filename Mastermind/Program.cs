namespace Mastermind;

class Program
{
    static void Main()
    {
        var theGame = new TheGame();

        theGame.StartGame();
        
        while (theGame.IsPlaying()) 
        {
            theGame.AskPlayer();
        }
    }
}
