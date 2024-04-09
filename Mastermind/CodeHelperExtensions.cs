using System;
namespace Mastermind;

public static class CodeHelperExtensions
{
    public static string ItemsToString<T>(this List<T> items)
    {
        return string.Join("", items);
    }

    public static string TakeUserInput()
    {
        var userInput = Console.ReadLine() ?? string.Empty;
        return userInput.Trim();
    }
}
