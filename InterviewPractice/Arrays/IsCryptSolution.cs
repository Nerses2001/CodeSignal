using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.InterviewPracticeArrays
{
    internal class IsCryptSolution
    {

        // A cryptarithm is a mathematical puzzle for which the goal is to find the correspondence between letters and digits,
        // such that the given arithmetic equation consisting of letters holds true when the letters are converted to digits.
        // You have an array of strings crypt, the cryptarithm, and an an array containing the mapping of letters and digits, solution.
        // The array crypt will contain three non-empty strings that follow the structure:
        // [word1, word2, word3], which should be interpreted as the word1 + word2 = word3 cryptarithm.
        // If crypt, when it is decoded by replacing all of the letters in the cryptarithm with digits using the mapping in solution,
        // becomes a valid arithmetic equation containing no numbers with leading zeroes, the answer is true.
        // If it does not become a valid arithmetic solution, the answer is false.
        // Note that number 0 doesn't contain leading zeroes (while for example 00 or 0123 do).
        public bool Solution(string[] crypt, char[][] solution)
        {

            Dictionary<char, char> solutionMap = solution.ToDictionary(pair => pair[0], pair => pair[1]);

            long sum = 0;
            for (int i = 0; i < crypt.Length; ++i)
            {
                if (crypt[i].Length > 1 && solutionMap[crypt[i][0]] == '0')
                {
                    return false;
                }

                if (i != 2)
                {
                    sum += long.Parse(CharNumber(crypt[i], solutionMap));
                }
                else
                {
                    sum -= long.Parse(CharNumber(crypt[i], solutionMap));
                }
            }

            return sum == 0;

        }

        private string CharNumber(string s, Dictionary<char, char> solutionMap)
        {
            string res = "";
            foreach (char c in s)
            {
                res = $"{res}{solutionMap[c]}";

            }
            return res;
        }

    }
}
