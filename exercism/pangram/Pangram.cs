using System;
using System.Linq;

public static class Pangram
{
    private static string _englishAlphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        if (input.Trim().Length == 0) {
            return false;
        }

        var cleanedInput = input
            .ToLower()
            .ToArray()
            .Where(
                (char character) => {
                    return character >= 'a' && character <= 'z';
                }
            )
            .Distinct()
            .OrderBy(character => character);

        return _englishAlphabet.SequenceEqual(cleanedInput);
    }
}
