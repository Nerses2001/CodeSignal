using System;
using System.Collections.Generic;

namespace CodeSignal.InterviewPracticeArrays
{
    internal class FirstNotRepeatingCharacter
    {

        // Given a string s consisting of small English letters,
        // find and return the first instance of a non-repeating character in it. If there is no such character, return '_'.
        public char Solution(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; ++i)
            {
                if (charCount.ContainsKey(s[i])) charCount[s[i]] = -1;
                else charCount[s[i]] = 1;
            }
            foreach (char c in s)
            {
                if (charCount[c] != -1)
                {
                    return c;
                }
            }
            return '_';

        }

    }
}
