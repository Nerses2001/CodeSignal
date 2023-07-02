using System;

namespace CodeSignal.Intro
{
    class DarkWilderness
    {
        // Caring for a plant can be hard work, but since you tend to it regularly, you have a plant that grows consistently.
        // Each day, its height increases by a fixed amount represented by the integer upSpeed. But due to lack of sunlight,
        // the plant decreases in height every night, by an amount represented by downSpeed.
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {

            if (desiredHeight <= upSpeed)
            {
                return 1;
            }

            return (int)Math.Ceiling((double)(desiredHeight - upSpeed) / (upSpeed - downSpeed)) + 1;
        }

        // You found two items in a treasure chest! The first item weighs weight1 and is worth value1,
        // and the second item weighs weight2 and is worth value2. What is the total maximum value of the items you can take with you,
        // assuming that your max weight capacity is maxW and you can't come back for the items later?
        // Note that there are only two items and you can't bring more than one item of each type, i.e.
        // you can't take two first items or two second items.
        public int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            var ret = 0;
            if (value1 > value2)
            {
                if (weight1 <= maxW)
                {
                    ret += value1;
                    maxW -= weight1;
                }
                if (weight2 <= maxW)
                {
                    ret += value2;
                    maxW -= weight2;
                }
            }
            else
            {
                if (weight2 <= maxW)
                {
                    ret += value2;
                    maxW -= weight2;
                }
                if (weight1 <= maxW)
                {
                    ret += value1;
                    maxW -= weight1;
                }
            }
            return ret;

        }

        // Given a string, output its longest prefix which contains only digits.
        public string LongestDigitsPrefix(string inputString)
        {
            if (!char.IsDigit(inputString[0]))
            {
                return "";
            }
            int k = 0;
            foreach (char c in inputString)
            {
                if (!char.IsDigit(c))
                {
                    break;
                }
                ++k;
            }
            return inputString.Substring(0, k);

        }
        // Let's define digit degree of some positive integer as the number of times we need to replace this number
        // with the sum of its digits until we get to a one digit number.
        public int DigitDegree(int n)
        {
            if (n < 10)
            {
                return 0;
            }
            int degree = 0;

            while (n >= 10)
            {
                n = GetDigitSum(n);
                degree++;
            }

            return degree;

        }
        private int GetDigitSum(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        // Given the positions of a white bishop and a black pawn on the standard chess board,
        // determine whether the bishop can capture the pawn in one move.
        // The bishop has no restrictions in distance for each move, but is limited to diagonal movement.
        // Check out the example below to see how it can move:
        public bool BishopAndPawn(string bishop, string pawn)
        {
            return -(int)bishop[0] + (int)pawn[0] == (int)pawn[1] - (int)bishop[1] || (int)bishop[0] - (int)pawn[0] == (int)pawn[1] - (int)bishop[1];
        }






    }
}
