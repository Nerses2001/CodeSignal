using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Intro
{
    class DivingDeeper
    {
        // Given array of integers, remove each k^th element from it.
        public int[] ExtractEachKth(int[] inputArray, int k)
        {
            int[] result = new int[inputArray.Length - inputArray.Length / k];
            int index = 0;
            for (int i = 0; i < inputArray.Length; ++i)
            {
                if ((i + 1) % k != 0)
                {
                    result[index] = inputArray[i];
                    ++index;
                }
            }
            return result;

        }

        // Find the leftmost digit that occurs in a given string.
        public char FirstDigit(string inputString)
        {
            char[] inputCharArry = inputString.ToArray();
            char res = '0';
            foreach (char c in inputString)
            {
                if (c >= '0' && c <= '9')
                {
                    res = c;
                    break;
                }
            }
            return res;
        }

        // Given a string, find the number of different characters in it.
        public int DifferentSymbolsNaive(string s)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                set.Add(c);
            }
            return set.Count;
        }

        // Given array of integers, find the maximal possible sum of some of its k consecutive elements.
        public int ArrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += inputArray[i];
            }

            maxSum = currentSum;

            for (int i = k; i < inputArray.Length; i++)
            {
                currentSum += inputArray[i] - inputArray[i - k];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;


        }










    }
}
