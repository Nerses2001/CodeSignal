using System.Text.RegularExpressions;

namespace CodeSignal.Intro
{
    class RainsOfReason
    {
        // Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem
        public int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (int i = 0; i < inputArray.Length; ++i)
            {
                if (inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }
            return inputArray;
        }

        // Check if all digits of the given integer are even.
        public bool EvenDigitsOnly(int n)
        {
            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
            /*string digits = number.ToString();
            foreach (char digit in digits)
            {
                if (int.Parse(digit.ToString()) % 2 != 0)
                {
                    return false;
                }
            }
            return true;*/
        }

        // Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.
        // Check if the given string is a correct variable name.
        public bool VariableName(string name)
        {

            string pattern = @"^[a-zA-Z_][a-zA-Z0-9_]*$";

            bool isMatch = Regex.IsMatch(name, pattern);

            return isMatch;
        }

        // Given a string, your task is to replace each of its characters by the next one in the English alphabet;
        // i.e. replace a with b, replace b with c, etc (z would be replaced by a).
        public string AlphabeticShift(string inputString)
        {
            char[] result = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; ++i)
            {
                char currentChar = inputString[i];
                char nextChar;

                if (currentChar == 'z')
                {
                    nextChar = 'a';
                }

                else if (char.IsLetter(currentChar))
                {
                    nextChar = (char)(currentChar + 1);
                }
                else
                {
                    nextChar = currentChar;
                }

                result[i] = nextChar;
            }
            return new string(result);
        }

        // Given two cells on the standard chess board, determine whether they have the same color or no
        public bool ChessBoardCellColor(string cell1, string cell2)
        {
            if ((int)cell1[0] % 2 == (int)cell1[1] % 2 && (int)cell2[0] % 2 == (int)cell2[1] % 2)
            {
                return true;
            }
            else if ((int)cell1[0] % 2 != (int)cell1[1] % 2 && (int)cell2[0] % 2 != (int)cell2[1] % 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }








    }
}
