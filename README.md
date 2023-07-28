## Description:

Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
```
  12 ==> 21
 513 ==> 531
2017 ==> 2071
```
If the digits can't be rearranged to form a bigger number, return ```-1``` (or ```nil``` in Swift, ```None``` in Rust):
```
  9 ==> -1
111 ==> -1
531 ==> -1
```
### My solution
```C#
using System.Collections.Generic;
using System.Linq;

public class Kata
{
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

            return long.Parse(string.Join("", nAsStr[0..(i - 1)],
                nextNumber, string.Join("", lastNumbers)));
        }

        return -1;
    }
}
```
