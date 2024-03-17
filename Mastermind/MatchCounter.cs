namespace Mastermind;

public class MatchCounter 
{
    public List<int> CountMatches(List<int> arr)
    {
        var matchCounter = new List<int>{0, 0, 0, 0, 0, 0};
        foreach (var digit in arr)
        {
            switch (digit)
            {
                case 1:
                    matchCounter[0] += 1;
                    break;
                case 2:
                    matchCounter[1] += 1;
                    break;
                case 3:
                    matchCounter[2] += 1;
                    break;
                case 4:
                    matchCounter[3] += 1;
                    break;
                case 5:
                    matchCounter[4] += 1;
                    break;
                case 6:
                    matchCounter[5] += 1;
                    break;
            }
        }
        return matchCounter;
    }
}