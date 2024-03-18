using System;
namespace Mastermind;

public static class CodeHelperExtensions
{
    public static string ItemsToString<T>(this List<T> items)
    {
        return string.Join("", items);
    }
}
