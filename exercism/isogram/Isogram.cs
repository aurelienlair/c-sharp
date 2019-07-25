using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word.Trim().Length == 0) {
            return true;
        }

        var repeatedChars = word
            .ToLower()
            .ToCharArray()
            .Where(
                (char character) => {
                    return character >= 'a' && character <= 'z';
                }
            )
            .GroupBy(character => character)
            .Where(character => character.Count() > 1)
            .Select(character => character.Key);

        return repeatedChars.Count() == 0;
    }
}
