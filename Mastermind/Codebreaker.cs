namespace Mastermind
{
    public class Codebraker
    {
        public List<int> UserInput()
        {
            Console.WriteLine("Enter a 4-digit code using numbers from 1 to 6, numbers may be repeated:");
            var userInputStr = Console.ReadLine() ?? string.Empty;

            var userInputCharArr = userInputStr.ToCharArray();
            var userInputInt = new List<int> ();

            for (var i = 0; i < userInputCharArr.Length; i++)
            {
                var c = (int)Char.GetNumericValue(userInputCharArr[i]);
                userInputInt.Add(c);
            }

            return userInputInt;
        }
    }
}