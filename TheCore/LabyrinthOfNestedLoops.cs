using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeSignal.TheCore
{
    internal class LabyrinthOfNestedLoops
    {
        // Determine if the given number is a power of some non-negative integer.
        public bool IsPower(int n)
        {
            if (n == 1) return true;

            int factor = 2;

            while (factor <= Math.Sqrt(n))
            {
                int number = n;
                while (number % factor == 0)
                {
                    number /= factor;
                }

                if (number == 1) return true;
                else ++factor;
            }

            return false;
        }


        // Find the number of ways to express n as sum of some (at least two) consecutive positive integers.
        public int IsSumOfConsecutive2(int n)
        {
            int count = 0;
            for (int i = 1; i * (i + 1) < 2 * n; ++i)
            {
                double tmp = (double)((1.0 * n - (i * (i + 1)) / 2) / (i + 1));

                if (tmp - (int)tmp == 0.0)
                    ++count;
            }

            return count;

        }

        // Consider a sequence of numbers a0, a1, ..., an, in which an element is equal to the sum of squared digits of the previous element.
        // The sequence ends once an element that has already been in the sequence appears again
        // Given the first element a0, find the length of the sequence.
        public int SquareDigitsSequence(int a0)
        {
            List<int> h = new List<int>();
            h.Add(a0);

            int n = a0.ToString().Select(c => int.Parse(c.ToString())).Select(el => el * el).Sum();

            while (!h.Contains(n))
            {
                h.Add(n);
                n = n.ToString().Select(c => int.Parse(c.ToString())).Select(el => el * el).Sum();
            }

            return h.Count + 1;
        }







    }
}
