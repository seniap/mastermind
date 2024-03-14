namespace Mastermind
{
    public class Codebraker
    {
        public List<int> UserInput()
        {
            Console.WriteLine("Enter a 4-digit code using numbers from 1 to 6, numbers may be repeated:");
            string userInputStr = Console.ReadLine();

            char[] userInputCharArr = userInputStr.ToCharArray();
            List<int> userInputInt = new List<int> ();

            for (int i = 0; i < userInputCharArr.Length; i++)
            {
                int c = (int)Char.GetNumericValue(userInputCharArr[i]);
                userInputInt.Add(c);
            }

            return userInputInt;
        }
    }
}