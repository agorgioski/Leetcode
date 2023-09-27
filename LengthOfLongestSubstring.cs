using System.Collections;
using System.Linq;

namespace LengthOfLongestSubstring;
public class Solution
{
    public void Run()
    {
        int longestSubstring = LengthOfLongestSubstring(Console.ReadLine());
        Console.WriteLine(longestSubstring);
    }

    // public int LengthOfLongestSubstring(string s)
    // {
    //     var charSet = new HashSet<char>();
    //     int left = 0, right = 0, maxLength = 0;
    //     while(right < s.Length)
    //     {
    //         if (!charSet.Contains(s[right]))
    //         {
    //             charSet.Add(s[right]);
    //             right++;
    //             maxLength = Math.Max(maxLength, charSet.Count);
    //         }
    //         else
    //         {
    //             charSet.Remove(s[left]);
    //             left++;
    //         }
    //     }
    //     return maxLength;
    // }
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> seen = new();
        int right = 0;
        int left = 0;
        int max = 0;

        while (right < s.Length)
        {
            if (!seen.Contains(s[right]))
            {
                seen.Add(s[right]);
                right++;
                max = Math.Max(max, seen.Count);
            }
            else
            {
                seen.Remove(s[left]);
                left++;
            }
        }

        return max;
    }
}