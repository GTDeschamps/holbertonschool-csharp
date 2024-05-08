using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            // Dictionary to store character frequency
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Populate the dictionary with character frequencies
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first non-repeating character
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            // Return -1 if no non-repeating character found
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            string input = "leetcode";
            int index = Str.UniqueChar(input);
            Console.WriteLine(index); // Output: 0 (since 'l' is the first non-repeating character at index 0)
        }
    }
}
