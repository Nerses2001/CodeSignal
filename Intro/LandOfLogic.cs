using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace CodeSignal.Intro
{
    class LandOfLogic
    {
        // Define a word as a sequence of consecutive English letters. Find the longest word from the given string
        public string LongestWord(string text)
        {
            string longestString = "";
            string tmp = "";
            int maxLength = 0;
            for (int i = 0; i < text.Length; ++i)
            {

                if (((int)text[i] >= 65 && (int)text[i] <= 90) || ((int)text[i] >= 97 && (int)text[i] <= 122))
                {
                    tmp += text[i];

                }
                else
                {
                    if (maxLength < tmp.Length)
                    {
                        longestString = tmp;
                        maxLength = longestString.Length;
                    }
                    tmp = "";
                }

            }
            if (longestString.Length < tmp.Length)
            {
                longestString = tmp;
            }


            return longestString;

        }

        // Check if the given string is a correct time representation of the 24-hour clock.
        public bool ValidTime(string time)
        {
            string strRegex = @"^([01]?[0-9]|2[0-3]):[0-5][0-9]$";
            Regex re = new Regex(strRegex);
            bool isValid = re.IsMatch(time);
            return isValid;

        }

        // CodeMaster has just returned from shopping. He scanned the check of the items he bought
        // and gave the resulting string to Ratiorg to figure out the total number of purchased items.
        // Since Ratiorg is a bot he is definitely going to automate it,
        // so he needs a program that sums up all the numbers which appear in the given input.
        public int SumUpNumbers(string inputString)
        {
            MatchCollection matches = Regex.Matches(inputString, @"\d+");

            int[] numbers = matches.Cast<Match>().Select(m => int.Parse(m.Value)).ToArray();
            int sum = numbers.Sum();

            return sum;
        }

        // Given a rectangular matrix containing only digits, calculate the number of different 2 × 2 squares in it.
        public int DifferentSquares(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            if (n <= 1 || m <= 1)
            {
                return 0;
            }
            HashSet<string> hs = new HashSet<string>();
            for (int i = 1; i < matrix.Length; ++i)
            {
                for (int j = 1; j < matrix[0].Length; ++j)
                {
                    hs.Add(matrix[i - 1][j - 1] + "," + matrix[i - 1][j] + "," + matrix[i][j - 1] + "," + matrix[i][j]);
                }
            }

            return hs.Count;
        }


        // Given an integer product, find the smallest positive
        // (i.e. greater than 0) integer the product of whose digits is equal to product.
        // If there is no such integer, return -1 instead.
        public int DigitsProduct(int product)
        {
            if (product == 0)
                return 10;

            if (product < 10)
                return product;

            int result = 0;

            for (int i = 9; i > 1; --i)
            {
                while (product % i == 0)
                {
                    result = result * 10 + i;
                    product /= i;
                }
            }

            if (product != 1)
                return -1;

            int smallestInteger = 0;
            while (result != 0)
            {
                smallestInteger = smallestInteger * 10 + result % 10;
                result /= 10;
            }

            return smallestInteger;
        }

        // You are given an array of strings names representing filenames.
        // The array is sorted in order of file creation, such that names[i]
        // represents the name of a file created before names[i+1] and after names[i-1]
        // (assume 0-based indexing). Because all files must have unique names, files created
        // later with the same name as a file created earlier should have an additional (k)
        // suffix in their names, where k is the smallest positive integer (starting from 1)
        // that does not appear in previous file names.

        public string[] FileNaming(string[] names)
        {

            HashSet<string> unrepeatableName = new HashSet<string>();

            for (int i = 0; i < names.Length; ++i)
            {
                string uniqueName = names[i];
                int count = 1;

                while (unrepeatableName.Contains(uniqueName))
                {
                    uniqueName = $"{names[i]}({count++})";
                }

                unrepeatableName.Add(uniqueName);
                names[i] = uniqueName;
            }

            return names;
        }

        // You are taking part in an Escape Room challenge designed specifically for programmers. In your efforts to find a clue,
        // you've found a binary code written on the wall behind a vase, and realized that it must be an encrypted message. After some thought,
        // your first guess is that each consecutive 8 bits of the code stand for the character with the corresponding extended ASCII code.
        // Assuming that your hunch is correct, decode the message.

        public string MessageFromBinaryCode(string code)
        {
            List<int> codeNumber = new List<int>();
            int num = 0;
            int pow = 7;
            for (int i = 0; i < code.Length; ++i)
            {

                if (code[i] == '1')
                {
                    num += (int)Math.Pow(2, pow);
                }

                --pow;

                if ((i + 1) % 8 == 0)
                {
                    codeNumber.Add(num);
                    pow = 7;
                    num = 0;
                }


            }
            string res = "";
            for (int i = 0; i < codeNumber.Count; ++i)
            {
                res += (char)codeNumber[i];
            }

            return res;

        }

        // Construct a square matrix with a size N × N containing integers from 1 to N * N in a spiral order,
        // starting from top-left and in clockwise direction.
        public int[][] SpiralNumbers(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < matrix.Length; ++i)
            {
                matrix[i] = new int[n];
            }

            int value = 1;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right; ++i)
                {
                    matrix[top][i] = value++;
                }
                ++top;

                for (int i = top; i <= bottom; ++i)
                {
                    matrix[i][right] = value++;
                }
                --right;

                for (int i = right; i >= left; --i)
                {
                    matrix[bottom][i] = value++;
                }
                --bottom;

                for (int i = bottom; i >= top; --i)
                {
                    matrix[i][left] = value++;
                }
                ++left;
            }

            return matrix;
        }

        // Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with digits so that each column, each row,
        // and each of the nine 3 × 3 sub-grids that compose the grid contains all of the digits from 1 to 9
        // This algorithm should check if the given grid of numbers represents a correct solution to Sudoku
        public bool Sudoku(int[][] grid)
        {
            for (int i = 0; i < 9; ++i)
            {
                HashSet<int> rowSet = new HashSet<int>();
                HashSet<int> colSet = new HashSet<int>();

                for (int j = 0; j < 9; ++j)
                {
                    int rowDigit = grid[i][j];
                    int colDigit = grid[j][i];

                    if (rowSet.Contains(rowDigit) || colSet.Contains(colDigit))
                    {
                        return false;
                    }
                    else
                    {
                        rowSet.Add(rowDigit);
                        colSet.Add(colDigit);
                    }
                }
            }

            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    HashSet<int> boxSet = new HashSet<int>();

                    for (int k = i; k < i + 3; ++k)
                    {
                        for (int l = j; l < j + 3; ++l)
                        {
                            int digit = grid[k][l];

                            if (boxSet.Contains(digit))
                            {
                                return false;
                            }
                            else
                            {
                                boxSet.Add(digit);
                            }
                        }
                    }
                }
            }

            return true;
        }

    }
}
