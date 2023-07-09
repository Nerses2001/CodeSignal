using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;


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

        // You work in a company that prints and publishes books.
        // You are responsible for designing the page numbering mechanism in the printer.
        // You know how many digits a printer can print with the leftover ink.
        // Now you want to write a function to determine what the last page of the book is that you can number given the
        // current page and numberOfDigits left. A page is considered numbered if it has the full number printed on
        // it (e.g. if we are working with page 102 but have ink only for two digits then this page will not be considered numbered)
        //It's guaranteed that you can number the current page, and that you can't number the last one in the book.
        public int PagesNumberingWithLnk(int current, int numberOfDigits)
        {
            while (numberOfDigits >= 0)
            {
                numberOfDigits -= (int)Math.Ceiling(Math.Log10(current + 1));
                ++current;
            }

            return current - 2;
        }


        // Main??
        // Let's say that number a feels comfortable with number b if a ≠ b and b
        // lies in the segment [a - s(a), a + s(a)], where s(x) is the sum of x's digits.
        // How many pairs(a, b) are there, such that a<b, both a and b lie on the segment[l, r],
        // and each number feels comfortable with the other (so a feels comfortable with b and b feels comfortable with a)?

        public int ComfortableNumbers(int l, int r)
        {
            List<(int, int)> ret = new List<(int, int)>();
            for (int i = l; i <= r; ++i)
            {
                for (int j = i + 1; j <= Math.Min(r, i + S(i)); ++j)
                {
                    if (i == j)
                        continue;
                    if (i >= j - S(j) && i <= j + S(j))
                    {
                        ret.Add((i, j));
                    }
                }
            }

            return ret.Distinct().Count();

        }
        private int S(int x) => x.ToString().Select(c => int.Parse(c.ToString())).Sum();

        // We define the weakness of number x as the number of positive integers smaller than x that have more divisors than x.
        // It follows that the weaker the number, the greater overall weakness it has. For the given integer n,
        // you need to answer two questions:
        // what is the weakness of the weakest numbers in the range [1, n]?
        // how many numbers in the range [1, n] have this weakness?
        // Return the answer as an array of two elements, where the first
        // element is the answer to the first question, and the second element is the answer to the second question.
        public int[] WeakNumbers(int n)
        {
            int[] d = new int[n];
            int w = 0;
            int wc = 0;

            for (int i = 1; i <= n; ++i)
            {
                int t = 0;
                d[i - 1] = NumDivisors(i);

                for (int j = 1; j < i; ++j)
                {
                    if (d[j - 1] > d[i - 1])
                        ++t;
                }

                if (t == w)
                {
                    ++wc;
                }
                else if (t > w)
                {
                    w = t;
                    wc = 1;
                }
            }

            return new int[] { w, wc };
        }
        private int NumDivisors(int x)
        {
            int count = 1;

            for (int i = 2; i <= x; ++i)
            {
                if (x % i == 0)
                    ++count;
            }

            return count;
        }


        // A rectangle with sides equal to even integers a and b is drawn on the Cartesian plane. Its center (the intersection point of its diagonals) coincides with the point (0, 0), but the sides of the rectangle are not parallel to the axes; instead, they are forming 45 degree angles with the axes.
        // How many points with integer coordinates are located inside the given rectangle(including on its sides)?

        public int RectangleRotation(int a ,int b) 
        { 
            double aHalf = (a / Math.Sqrt(2)) / 2;
            double bHalf = (b / Math.Sqrt(2)) / 2;
            int[] rectA = new int[2];
            int[] rectB = new int[2];

            rectA[0] = (int)(Math.Floor(aHalf) * 2) + 1;
            rectA[1] = (int)(Math.Floor(bHalf) * 2) + 1;

            if (aHalf - Math.Floor(aHalf) < 0.5)
            {
                rectB[0] = rectA[0] - 1;
            }
            else
            {
                rectB[0] = rectA[0] + 1;
            }

            if (bHalf - Math.Floor(bHalf) < 0.5)
            {
                rectB[1] = rectA[1] - 1;
            }
            else
            {
                rectB[1] = rectA[1] + 1;
            }

            return rectA[0] * rectA[1] + rectB[0] * rectB[1];

        }


    }
}
