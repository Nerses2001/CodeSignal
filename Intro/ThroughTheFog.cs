using System;


namespace CodeSignal.Intro
{
    internal class ThroughTheFog
    {
        // Consider integer numbers from 0 to n - 1 written down along the circle in such
        // a way that the distance between any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
        // Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.
        public int CircleOfNumbers(int n, int firstNumber)
        {
            return (firstNumber + n / 2) % n;
        }

        // You have deposited a specific amount of money into your bank account. Each year your balance increases at the same growth rate.
        // With the assumption that you don't make any additional deposits, find out how long it would take for your balance to pass a specific threshold.
        public int DepositProfit(int deposit, int rate, int threshold)
        {
            double dep = deposit;
            int k = 0;
            while (dep < threshold)
            {
                dep = dep + dep * rate / 100;
                ++k;
            }
            return k;
        }

        // Given a sorted array of integers a, your task is to determine which element of a is closest to all other values of a.
        // In other words, find the element x in a, which minimizes the following sum: 
        // abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x)
        public int AbsoluteValuesSumMinimization(int[] a)
        {
            int n = a.Length;
            int minSum = int.MaxValue;
            int minElement = -1;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                for (int j = 0; j < n; j++)
                {
                    sum += Math.Abs(a[i] - a[j]);
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    minElement = a[i];
                }
            }

            return minElement;
        }

        // Given an array of equal-length strings, you'd like to know if it's possible to rearrange
        // the order of the elements in such a way that each consecutive pair of strings differ by exactly one character.
        // Return true if it's possible, and false if not.
        // Note: You're only rearranging the order of the strings, not the order of the letters within the strings!


        private  bool _success = false;

        public bool StringsRearrangement(string[] inputArray)
        {
            bool[] used = new bool[inputArray.Length];
            FindSequence(inputArray, string.Empty, used, 0);
            return _success;
        }

        private void FindSequence(string[] a, string prev, bool[] used, int n)
        {
            if (n == a.Length)
            {
                _success = true;
                return;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (!used[i] && (prev.Length == 0 || DifferByOne(prev, a[i])))
                {
                    used[i] = true;
                    FindSequence(a, a[i], used, n + 1);
                    used[i] = false;
                }
            }
        }

        private bool DifferByOne(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    count++;
                }
            }
            return count == 1;
        }





    }
}
