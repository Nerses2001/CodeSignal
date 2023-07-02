using System.Linq;


namespace CodeSignal.TheCore
{
    class IntroGates
    {
        // You are given a two-digit integer n. Return the sum of its digits.
        public int AddTwoDigits(int n) => n / 10 + n % 10;

        // Given an integer n, return the largest number that contains exactly n digits.
        public int LargestNumber(int n) =>  Pow(10, n) - 1;

        private int Pow(int baseNumber, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

        // n children have got m pieces of candy. They want to eat as much candy as they can,
        // but each child must eat exactly the same amount of candy as any other child.
        // Determine how many pieces of candy will be eaten by all the children together.
        // Individual pieces of candy cannot be split.
        public int Candies(int n, int m) =>  n * (m / n);

        // our friend advised you to see a new performance in the most popular theater in the city.
        // He knows a lot about art and his advice is usually good, but not this time:
        // the performance turned out to be awfully dull. It's so bad you want to sneak out, which is quite simple, especially
        // since the exit is located right behind your row to the left. All you need to do is climb over your seat and make your way to the exit.
        public int SeatsInTheater(int nCols, int nRows, int col, int row) => (nRows - row) * (nCols - col + 1);

        // Given a divisor and a bound, find the largest integer N such that:

        public int MaxMultiple(int divisor, int bound) => bound % divisor == 0 ? bound : bound - bound % divisor;

        // Consider integer numbers from 0 to n - 1 written down along the circle in such a way that
        // the distance between any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
        public int CircleOfNumbers(int n, int firstNumber) => (firstNumber + n / 2) % n;

        // One night you go for a ride on your motorcycle. At 00:00 you start your engine,
        // and the built-in timer automatically begins counting the length of your ride, in minutes. Off you go to explore the neighborhood.
        // When you finally decide to head back, you realize there's a chance the bridges on your route home are up, leaving you stranded! Unfortunately,
        // you don't have your watch on you and don't know what time it is.
        // All you know thanks to the bike's timer is that n minutes have passed since 00:00.
        public int LateRide(int n)
        {
            int hours = n / 60;
            int minutes = n % 60;

            string hoursStr = hours.ToString();
            string minutesStr = minutes.ToString();

            int hoursDigitSum = hoursStr.Sum(digit => int.Parse(digit.ToString()));
            int minutesDigitSum = minutesStr.Sum(digit => int.Parse(digit.ToString()));

            return hoursDigitSum + minutesDigitSum;

        }

        // Some phone usage rate may be described as follows:
        // first minute of a call costs min1 cents,
        // each minute from the 2nd up to 10th (inclusive) costs min2_10 cents
        // each minute after 10th costs min11 cents.
        // You have s cents on your account before the call. What is the duration of the longest call
        // (in minutes rounded down to the nearest integer) you can have?
        public int PhoneCall(int min1, int min2_10, int min11, int s)
        {
            if (s == min1)
                return 1;
            else if (s < min1)
                return 0;
            else if (s <= min1 + (min2_10 * 9))
                return (s - min1) / min2_10 + 1;
            else
            {
                int remainingBalance = s - (min1 + (min2_10 * 9));
                int additionalMinutes = remainingBalance / min11;

                return 10 + additionalMinutes;
            }
        }





    }







}
    
