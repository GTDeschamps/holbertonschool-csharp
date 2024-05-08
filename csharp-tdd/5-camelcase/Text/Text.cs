using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int count = 1; // Initialize count to 1 for the first word
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
