using System;


namespace CodeSignal.Intro
{
    class RainbowOfClarity
    {
        // Determine if the given character is a digit or not.
        public bool IsDigit(char symbol) => (int)symbol - 48 < 10 && (int)symbol - 48 >= 0;

        // Given a string, return its encoding defined as follows:
        // First, the string is divided into the least possible number of disjoint substrings consisting of identical characters.
        // for example, "aabbbc" is divided into ["aa", "bbb", "c"]
        // Next, each substring with length greater than one is replaced with a concatenation of its length and the repeating character
        // for example, substring "bbb" is replaced by "3b"
        // Finally, all the new strings are concatenated together in the same order and a new string is returned.
        public string LineEncoding(string s)
        {
            string res = "";
            int count = 1;
            int[] counts = new int[s.Length];

            for (int i = 0; i < s.Length - 1; ++i)
            {
                if (s[i] != s[i + 1])
                {
                    counts[i] = count;
                    count = 0;
                }

                count++;
            }

            counts[s.Length - 1] = count;

            for (int i = 0; i < counts.Length; ++i)
            {
                if (counts[i] > 1)
                {
                    res += counts[i].ToString() + s[i];
                }
                else if (counts[i] == 1)
                {
                    res += s[i];
                }
            }

            return res;
        }

        // Given a position of a knight on the standard chessboard, find the number of different moves the knight can perform.
        // The knight can move to a square that is two squares horizontally and one square vertically, or two squares vertically and
        // one square horizontally away from it. The complete move therefore looks like the letter L.
        // Check out the image below to see all valid moves for a knight piece that is placed on one of the central squares.
        public int ChessKnight(string cell)
        {
            int count = 0;

            int column = cell[0] - 'a' + 1;
            int row = int.Parse(cell[1].ToString());

            if (column - 2 >= 1 && row - 1 >= 1)
            {
                ++count;
            }
            if (column - 2 >= 1 && row + 1 <= 8)
            {
                ++count;
            }
            if (column - 1 >= 1 && row - 2 >= 1)
            {
                ++count;
            }
            if (column - 1 >= 1 && row + 2 <= 8)
            {
                ++count;
            }
            if (column + 1 <= 8 && row - 2 >= 1)
            {
                ++count;
            }
            if (column + 1 <= 8 && row + 2 <= 8)
            {
                ++count;
            }
            if (column + 2 <= 8 && row - 1 >= 1)
            {
                ++count;
            }
            if (column + 2 <= 8 && row + 1 <= 8)
            {
                ++count;
            }

            return count;

        }

        // Given some integer, find the maximal number you can obtain by deleting exactly one digit of the given number.
        public int DeleteDigit(int n)
        {
            string s = n.ToString();
            int maxNumber = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                string modifiedNumberString = s.Remove(i, 1);
                int modifiedNumber = int.Parse(modifiedNumberString);
                maxNumber = Math.Max(maxNumber, modifiedNumber);
            }

            return maxNumber;
        }









    }
}
