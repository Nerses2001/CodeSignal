using System;
using System.Linq;


namespace CodeSignal.TheCore
{
    class AtTheCrossroads
    {
        // In order to stop the Mad Coder evil genius you need to decipher the encrypted message he sent to his minions.
        // The message contains several numbers that, when typed into a supercomputer,
        // will launch a missile into the sky blocking out the sun, and making all the people on Earth grumpy and sad.
        // You figured out that some numbers have a modified single digit in their binary representation. More specifically,
        // in the given number n the kth bit from the right was initially set to 0, but its current value might be different.
        // It's now up to you to write a function that will change the kth bit of n back to 0
        public int KillK_thBit(int n, int k) => n & ~(1 << (k - 1));

        // You are given an array of up to four non-negative integers, each less than 256.
        // Your task is to pack these integers into one number M in the following way:
        // The first element of the array occupies the first 8 bits of M
        // The second element occupies next 8 bits, and so on.
        // Return the obtained integer M.
        // Note: the phrase "first bits of M" refers to the least significant bits of M - the right-most bits of an integer.
        // For further clarification see the following example
        public int ArrayPacking(int[] a)
        {
            int M = 0;
            for (int i = 0; i < a.Length; i++)
            {
                M |= a[i] << (i * 8);
            }
            return M;
        }

        // You are given two numbers a and b where 0 ≤ a ≤ b. Imagine you construct an array of all the integers from a to b inclusive.
        // You need to count the number of 1s in the binary representations of all the numbers in the array.
        public int RangeBitCount(int a, int b)
        {
            int ret = 0;
            for (int i = a; i <= b; i++)
            {
                ret += Enumerable.Range(0, 4).Sum(d => (i & (1 << d)) >> d);
            }
            return ret;

        }

        // Reverse the order of the bits in a given integer.
        public int MirrorBits(int a)
        {
            int rev = 0;

            while (a > 0)
            {
                rev <<= 1;

                if ((int)(a & 1) == 1)
                    rev ^= 1;

                a >>= 1;
            }
            return rev;
        }

        // Presented with the integer n, find the 0-based position of
        // the second rightmost zero bit in its binary representation
        // (it is guaranteed that such a bit exists), counting from right to left.
        // Return the value of 2^position_of_the_found_bit.
        public int SecondRightmostZeroBit(int n) => 1 << Convert.ToString(n, 2).Length -
            Convert.ToString(n, 2).LastIndexOf("0", Convert.ToString(n, 2).LastIndexOf("0") - 1) -1;


        // You're given two integers, n and m. Find position of the rightmost bit in which they differ in their binary representations
        // (it is guaranteed that such a bit exists), counting from right to left.
        // Return the value of 2^position_of_the_found_bit (0-based).

        public int DifferentRightmostBit(int n, int m) => (~(n ^ m) + 1) & (n ^ m);


    }
}
