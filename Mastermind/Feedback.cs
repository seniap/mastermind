namespace Mastermind
{
    public class Feedback
    {
        public bool GuessFeedback(List<int> code, List<int> input)
        {
            bool playGame = true;
            char correctVal = 'X';
            char correctIndx = 'V';
            char defaultCh = '.';

            var matchCounter = new MatchCounter();
            var matchingIntCode = matchCounter.CountMatches(code);
            var matchingIntInput = matchCounter.CountMatches(input);

            if (string.Join( "", input.ToArray()) == string.Join( "", code.ToArray()))
            {
                playGame = !playGame;
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine("GAME OVER");
            }
            else
            {
                List<char> feedback = new List<char>();

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == code[i])
                    {
                        feedback.Add(correctIndx);
                    }
                    else if (input[i] != code[i] && code.Contains(input[i]) && matchingIntCode[input[i]-1] >= matchingIntInput[input[i]-1])
                    {
                        feedback.Add(correctVal);
                    }
                    else
                    {
                        feedback.Add(defaultCh);
                    }
                }

                var shuffledFeedback = feedback.OrderBy( x => Random.Shared.Next()).ToList( );
                var shuffledFeedbackStr = string.Join( "", shuffledFeedback.ToArray());

                Console.WriteLine(shuffledFeedbackStr);
            }
            return playGame;
        }
    }
}
