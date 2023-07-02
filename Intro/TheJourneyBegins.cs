

namespace CodeSignal.Intro.TheJourneyBegins
{
    internal class TheJourneyBegins
    {
        // Write a function that returns the sum of two numbers.
        public int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        // Given a year, return the century it is in.
        // The first century spans from the year 1 up to and including the year 100,
        // the second - from the year 101 up to and including the year 200, etc.
        public int ceturyFromYear(int year)
        {
            if (year % 100 == 0) return year / 100;
            return (year / 100) + 1;   
        }

        // Given the string, check if it is a palindrome.
        public bool CheckPalindrome(string inputString)
        {
            int left = 0;
            int right = inputString.Length - 1;

            while (left < right)
            {
                if (inputString[left] != inputString[right]) return false;
                ++left;
                --right;
            }
            return true;
        }









    }
}
