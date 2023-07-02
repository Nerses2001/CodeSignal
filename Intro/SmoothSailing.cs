using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal.Intro
{
    class SmoothSailing
    {
        // Given an array of strings, return another array containing all of its longest strings.
        public string[] AllLongestStrings(string[] inputArray)
        {
            int[] length = new int[inputArray.Length];
            List<string> longestStrings = new List<string>();

            for (int i = 0; i < inputArray.Length; ++i)
            {
                length[i] = inputArray[i].Length;
            }


            int max = length.Max();

            for (int i = 0; i < length.Length; ++i)
            {
                if (length[i] == max)  longestStrings.Add(inputArray[i]);
                
            }

            return longestStrings.ToArray();
        }

        // Given two strings, find the number of common characters between them.
        public int CommonCharacterCount(string s1, string s2)
        {

            int n1 = s1.Length;
            int n2 = s2.Length;

            int[] countS1 = new int[26];
            int[] countS2 = new int[26];

            int count = 0;

            for (int i = 0; i < n1; ++i)
            {
                countS1[s1[i] - 'a']++;
            }

            for (int i = 0; i < n2; ++i)
            {
                countS2[s2[i] - 'a']++;
            }

            for (int i = 0; i < 26; ++i)
            {
                count += (Math.Min(countS1[i], countS2[i]));
            }
            return count;
        }

        // Ticket numbers usually consist of an even number of digits.
        // A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.
        // Given a ticket number n, determine if it's lucky or not.
        public bool IsLucky(int n)
        {
            int ticketNumber = n;
            int length = 0;
            int temp = ticketNumber;

            while (temp != 0)
            {
                temp /= 10;
                ++length;
            }

            int halfLength = length / 2;
            int firstHalfSum = 0;
            int secondHalfSum = 0;

            for (int i = 0; i < length; ++i)
            {
                int digit = ticketNumber % 10;
                ticketNumber /= 10;

                if (i < halfLength)
                {
                    firstHalfSum += digit;
                }
                else
                {
                    secondHalfSum += digit;
                }
            }

            return firstHalfSum == secondHalfSum;
        }

        // Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people
        // by their heights in a non-descending order without moving the trees. People can be very tall!
        public int[] SortByHeight(int[] a)
        {

            List<int> peopleHeights = new List<int>();
            List<int> positions = new List<int>();

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != -1)
                {
                    peopleHeights.Add(a[i]);
                    positions.Add(i);
                }
            }

            CountigSort(ref peopleHeights);

            int currentIndex = 0;

            for (int i = 0; i < positions.Count; ++i)
            {
                a[positions[i]] = peopleHeights[currentIndex++];
            }

            return a;
        }

        private void CountigSort(ref List<int> inputArray)
        {
            if (inputArray.Count <= 1)
            {
                return;
            }

            int max = inputArray.Max();
            int min = inputArray.Min();

            int[] counts = new int[max - min + 1];
            int[] res = new int[inputArray.Count];

            for (int i = 0; i < inputArray.Count; ++i)
            {
                ++counts[inputArray[i] - min];

            }

            int k = 0;
            for (int i = 0; i < counts.Length; ++i)
            {
                while (counts[i] != 0)
                {
                    res[k++] = i + min;
                    --counts[i];
                }
            }
            inputArray = res.ToList();
        }

        // Write a function that reverses characters in (possibly nested) parentheses in the input string.
        // Input strings will always be well-formed with matching ()s.
        public string ReverseInParentheses(string inputString)
        {
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < inputString.Length; ++i)
            {
                if (inputString[i] == '(')
                {
                    st.Push(i);
                }
                else if (inputString[i] == ')')
                {
                    char[] A = inputString.ToCharArray();
                    ReverseString(ref A, st.Peek() + 1, i);
                    inputString = new string(A);
                    st.Pop();
                }

            }
            string res = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ')' && inputString[i] != '(')
                {
                    res += string.Format("{0}", inputString[i]);

                }
            }
            return res;
        }

        private void ReverseString(ref char[] A, int l, int h)
        {
            if (l < h)
            {
                char ch = A[l];
                A[l] = A[h];
                A[h] = ch;
                ReverseString(ref A, l + 1, h - 1);
            }
        }











    }
}
