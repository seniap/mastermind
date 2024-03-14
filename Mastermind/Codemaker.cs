namespace Mastermind
{
    public class Codemaker
    {
        public List<int> SecretCode()
        {
            List<int> secretCode = new List<int> ();
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                secretCode.Add(r.Next(1, 7));
            }

            // Console.WriteLine(string.Join( "", secretCode.ToArray()));

            return secretCode;
        }
    }
}
