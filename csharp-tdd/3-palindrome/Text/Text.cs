using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Remove spaces and punctuation, convert string to lowercase
            string cleanedString = Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();

            int left = 0;
            int right = cleanedString.Length - 1;

            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
