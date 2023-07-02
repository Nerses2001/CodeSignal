using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Intro
{
    class ExploringTheWaters
    {
        // Several people are standing in a row and need to be divided into two teams.
        // The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.
        // You are given an array of positive integers - the weights of the people. Return an array of two integers, where the first element is
        // the total weight of team 1, and the second element is the total weight of team 2 after the division is complete
        public int[] AlternatingSums(int[] a)
        {
            int res2 = 0;
            int res1 = 0;

            for (int i = 1; i < a.Length; i += 2)
            {
                res2 += a[i];
                res1 += a[i - 1];
            }
            if (a.Length % 2 != 0)
            {
                res1 += a.Last();
            }
            int[] res = { res1, res2 };
            Console.WriteLine(res1 + " " + res2);
            return res;
        }


        // Given a rectangular matrix of characters, add a border of asterisks(*) to it.
        public string[] AddBorder(string[] picture)
        {
            int m = picture[0].Length;
            string addElement = "";

            for (int i = 0; i < m + 2; ++i)
            {
                addElement += "*";
            }
            string[] result = new string[picture.Length + 2];

            result[0] = addElement;

            for (int i = 0; i < picture.Length; ++i)
            {
                result[i + 1] = string.Format("*{0}*", picture[i]);
            }

            result[result.Length - 1] = addElement;


            return result;
        }

        // Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.
        // Given two arrays a and b, check whether they are similar.
        public bool AreSimilar(int[] a, int[] b)
        {
            int count = 0;

            if (a.Length != b.Length) return false;

            int max = a[0];

            if (a.Max() != b.Max()) return false;
            else  max = a.Max();
            
            int[] countsA = new int[max + 1];
            int[] countsB = new int[max + 1];

            for (int i = 0; i < a.Length; ++i)
            {
                ++countsA[a[i]];
                ++countsB[b[i]];
                if (a[i] != b[i])
                {
                    ++count;
                }
            }

            if (count > 2) return false;

            for (int i = 0; i < countsA.Length; ++i)
            {
                if (countsA[i] != countsB[i]) return false;
            }



            return true;
        }

        // You are given an array of integers. On each move you are allowed to increase exactly one of its element by one.
        // Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
        public int ArrayChange(int[] inputArray)
        {
            int count = 0;
            for (int i = 1; i < inputArray.Length; ++i)
            {

                if (inputArray[i - 1] >= inputArray[i])
                {
                    int diff = inputArray[i - 1] - inputArray[i] + 1;
                    count += diff;
                    inputArray[i] = inputArray[i - 1] + 1;
                }
            }

            return count;
        }

        //Given a string, find out if its characters can be rearranged to form a palindrome.
        public bool PalindromeRearranging(string inputString)
        {

            Dictionary<char, int> charFreq = new Dictionary<char, int>();

            for (int i = 0; i < inputString.Length; ++i)
            {

                if (charFreq.ContainsKey(inputString[i]))
                {
                    ++charFreq[inputString[i]];
                }
                else
                {
                    charFreq.Add(inputString[i], 1);
                }

            }

            int odd = 0;

            foreach (int value in charFreq.Values)
            {
                if ((value & 1) == 1)
                {
                    ++odd;
                }

                if (odd > 1)
                {
                    return false;
                }

            }
            return true;
        }

    }
}
