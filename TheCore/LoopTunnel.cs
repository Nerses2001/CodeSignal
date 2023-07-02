using System;

namespace CodeSignal.TheCore
{
     class LoopTunnel
    {
        // Given an integer n, find the minimal k such that
        // k = m! (where m! = 1 * 2 * ... * m) for some integer m;
        // k >= n
        // In other words, find the smallest factorial which is not less than n.
        public int LeastFactorial(int n)
        {
            int f = 1;
            int i = 1;
            while (f < n)
            {
                f *= ++i;
            }
            return f;
        }

        // Given integers n, l and r, find the number of ways to represent n as a sum of two integers A and B such that l ≤ A ≤ B ≤ r.
        public int CountSumOfTwoRepresentations2(int n, int l, int r)
        {

            if (2 * r < n || 2 * l > n)
                return 0;

            int min = Math.Max(l, n - r);
            int max = Math.Min(r, n - l);

            int count = (max - min) / 2 + 1;

            return count;

        }

        // You are standing at a magical well. It has two positive integers written on it: a and b. Each time you cast a magic marble into the well,
        // it gives you a * b dollars and then both a and b increase by 1. You have n magic marbles. How much money will you make?
        public int MagicalWell(int a, int b, int n)
        {
            int mony = 0;
            while (n != 0)
            {
                mony = mony + a++ * b++;
                --n;
            }
            return mony;
        }

        // To prepare his students for an upcoming game, the sports coach decides to try some new training drills.
        // To begin with, he lines them up and starts with the following warm-up exercise:
        // when the coach says 'L', he instructs the students to turn to the left.
        // Alternatively, when he says 'R', they should turn to the right.
        // Finally, when the coach says 'A', the students should turn around.
        // Unfortunately some students (not all of them, but at least one) can't tell left from right,
        // meaning they always turn right when they hear 'L' and left when they hear 'R'.
        // The coach wants to know how many times the students end up facing the same direction.
        // Given the list of commands the coach has given,
        // count the number of such commands after which the students will be facing the same direction.
        public int Lineup(string commands)
        {
            int degt = 0;
            int tmp = 0;
            foreach (char c in commands)
            {
                if (c == 'L') degt += -90;
                
                if (c == 'R') degt += 90;
                
                if (c == 'A') degt += -180;
                
                if (degt % 180 == 0)
                {
                    ++tmp;
                    degt = 0;
                }

            }
            return tmp;
        }

        // A little child is studying arithmetic. They have just learned how to add two integers,
        // written one below another, column by column. But the child always forgets about the important part - carrying.
        // Given two integers, your task is to find the result that the child will get.
        // Note: The child had learned from this site, so feel free to check it out too if you are not familiar with column addition
        public int AdditionWithoutCarrying(int param1, int param2)
        {
            string p1 = param1.ToString();
            string p2 = param2.ToString();

            if (p1.Length > p2.Length)
            {
                p2 = p2.PadLeft(p1.Length, '0');
            }
            else if (p1.Length < p2.Length)
            {
                p1 = p1.PadLeft(p2.Length, '0');
            }


            string res = "";

            for (int i = 0; i < p1.Length; ++i)
            {
                int sum = int.Parse(p1[i].ToString()) + int.Parse(p2[i].ToString());
                if (sum >= 10)
                {
                    res += (sum - 10).ToString();
                }
                else
                {
                    res += sum.ToString();
                }
            }

            return int.Parse(res);
        }

        // You have k apple boxes full of apples. Each square box of size m contains m × m apples.
        // You just noticed two interesting properties about the boxes:
        // 1. The smallest box is size 1, the next one is size 2,..., all the way up to size k.
        // 2. Boxes that have an odd size contain only yellow apples. Boxes that have an even size contain only red apples.
        // Your task is to calculate the difference between the number of red apples and the number of yellow apples.
        public int AppleBoxes(int k)
        {
            /*
            if(k == 0) return 0;
            if(k == 1) return -1;

            int res = -1;
            for(int i = 2; i <= k; ++i)
            {
                if(i % 2 == 0)
                {
                    res += i * i;
                }
                else
                {
                    res -= i * i;
                }

            }
            return res;
            */
            int result = 0;
            if (k % 2 == 0)
            {
                result = k * (k + 1) / 2;
            }
            else
            {
                result = k * (k + 1) / -2;
            }
            return result;
        }

        // Define an integer's roundness as the number of trailing zeroes in it.
        // Given an integer n, check if it's possible to increase n's roundness by swapping some pair of its digits.
        public bool IncreaseNumberRoundness(int n)
        {
            string s = n.ToString();
            for (int i = 1; i < s.Length; ++i)
            {
                if (s[i] != s[i - 1] && s[i - 1] == '0')
                {
                    return true;
                }
            }
            return false;

        }

        // We want to turn the given integer into a number that has only one non-zero digit using a tail rounding approach.
        // This means that at each step we take the last non 0 digit of the number and round it to 0 or to 10.
        // If it's less than 5 we round it to 0 if it's larger than or equal to 5 we round it to 10
        // (rounding to 10 means increasing the next significant digit by 1).
        // The process stops immediately once there is only one non-zero digit left.
        public int Rounders(int n)
        {
            if (n < 10) return n;
            

            int i = 1;

            while (n >= Math.Pow(10, i))
            {
                int digit = (int)((n / Math.Pow(10, i - 1)) % 10);

                if (digit >= 5)  
                    n = (int)(n / Math.Pow(10, i)) * (int)Math.Pow(10, i) + (int)Math.Pow(10, i++);
                else 
                    n = (int)(n / Math.Pow(10, i)) * (int)Math.Pow(10, i++);

            }

            return n;
        }

        // When a candle finishes burning it leaves a leftover. makeNew leftovers can be combined to make a new candle,
        // which, when burning down, will in turn leave another leftover.
        // You have candlesNumber candles in your possession.
        // What's the total number of candles you can burn,
        // assuming that you create new candles as soon as you have enough leftovers?
        public int Candles(int candlesNumber, int makeNew)
        {
            return CalculateCandles(candlesNumber, makeNew, 0, 0);

        }
        private int CalculateCandles(int candlesNumber, int makeNew, int total, int leftover)
        {
            if (candlesNumber <= 0)
            {
                return total;
            }

            total += candlesNumber;
            leftover += candlesNumber;
            candlesNumber = leftover / makeNew;
            leftover %= makeNew;

            return CalculateCandles(candlesNumber, makeNew, total, leftover);
        }

        // Imagine a white rectangular grid of n rows and m columns divided into two parts by a
        // diagonal line running from the upper left to the lower right corner.
        // Now let's paint the grid in two colors according to the following rules
        // A cell is painted black if it has at least one point in common with the diagonal;
        // Otherwise, a cell is painted white.
        // Count the number of cells painted black.
        public int CountBlackCells(int n, int m)
        {
            if (n == 1) return m;
            if (m == 1) return n;

            int blackCount = n + m + Gcd(n, m) - 2;
            return blackCount;
        }

        private int Gcd(int a, int b)
        {
            if (b != 0) return Gcd(b, a % b);
            else return a;
        }


    }
}
