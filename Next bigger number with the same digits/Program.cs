using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static void Main()
    {
        // Test
        var t = NextBiggerNumber(1234567890);
        // ...should return 1234567908
    }

    public static long NextBiggerNumber(long n)
    {
        string nAsStr = n.ToString();

        for (int i = nAsStr.Length - 1; i > 0; i--)
        {
            if (nAsStr[i] <= nAsStr[i - 1])
                continue;

            char nextNumber = nAsStr.Last(c => c > nAsStr[i - 1]);
            var lastNumbers = nAsStr[(i - 1)..].OrderBy(c => c).ToList();
            lastNumbers.Remove(nextNumber);

            return long.Parse(string.Join("", nAsStr[0..(i - 1)], nextNumber, string.Join("", lastNumbers)));
        }

        return -1;
    }
}