using System;
using System.Collections.Generic;

namespace CodeSignal.TheCore
{
    internal class MirrorLake
    {
        // Given two strings a and b, both consisting only of lowercase English letters, your task is to calculate how many
        // strings equal to a can be constructed using only letters from the string b? Each letter can be used only once and in one string only.

        public int StringsConstruction(string a, string b)
        {
            int[] aRes = new int[26];
            int[] bRes = new int[26];

            foreach (char c in a)
            {
                ++aRes[c - 'a'];
            }

            foreach (char c in b)
            {
                ++bRes[c - 'a'];
            }

            int minCount = int.MaxValue;

            for (int i = 0; i < 26; ++i)
            {
                if (aRes[i] > 0)
                {
                    if (bRes[i] == 0) return 0;
                    else
                    {
                        int count = bRes[i] / aRes[i];
                        minCount = Math.Min(minCount, count);
                    }
                }
            }

            return minCount;
        }

        // A ciphertext alphabet is obtained from the plaintext
        // alphabet by means of rearranging some characters. For example
        // "bacdef...xyz" will be a simple ciphertext alphabet where a and b are rearranged.
        // A substitution cipher is a method of encoding where each letter of the plaintext alphabet is
        // replaced with the corresponding(i.e.having the same index) letter of some ciphertext alphabet.
        // Given two strings, check whether it is possible to obtain them from each other using some (possibly, different) substitution ciphers.
        public bool IsSubstitutionCipher(string string1, string string2)
        {

            if (string1.Length != string2.Length)
                return false;

            Dictionary<char, char> mapping = new Dictionary<char, char>();

            for (int i = 0; i < string1.Length; ++i)
            {
                char char1 = string1[i];
                char char2 = string2[i];

                if (!mapping.ContainsKey(char1))
                {
                    if (mapping.ContainsValue(char2))
                        return false;

                    mapping[char1] = char2;
                }
                else if (mapping[char1] != char2)
                {
                    return false;
                }
            }

            return true;

        }


    }
}
