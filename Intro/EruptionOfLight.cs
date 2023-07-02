using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignal.Intro
{
    class EruptionOfLight
    {
        // A string is said to be beautiful if each letter in the string appears at most as many times as the previous letter in the alphabet within the string;
        // ie: b occurs no more times than a; c occurs no more times than b; etc.
        // Note that letter a has no previous letter. 
        // Given a string, check whether it is beautiful.
        public bool IsBeautifulString(string inputString)
        {

            int[] counts = new int[26 + 1];

            foreach (char c in inputString)
            {
                ++counts[(int)c - 'a'];
            }
            int max = counts[0];
            for (int i = 0; i < counts.Length; ++i)
            {
                if (counts[i] > max)
                {
                    return false;
                }
                max = counts[i];
            }
            return true;
        }

        // An email address such as "John.Smith@example.com" is made up of a local part ("John.Smith"),
        // an "@" symbol, then a domain part ("example.com").
        // The domain name part of an email address may only consist of letters, digits, hyphens and dots.
        // The local part, however, also allows a lot of different special characters.
        // Here you can look at several examples of correct and incorrect email addresses.
        // Given a valid email address, find its domain part.
        public string FindEmailDomain(string address)
        {
            return address.Split('@').Last();
        }

        // Given a string, find the shortest possible string which can be achieved
        // by adding characters to the end of initial string to make it a palindrome.
        public string BuildPalindrome(string st)
        {
            string ret = st;
            var it = st.GetEnumerator();
            while (ret != new string(ret.Reverse().ToArray()))
            {
                it.MoveNext();
                ret = ret.Insert(st.Length, it.Current.ToString());
            }
            return ret;

        }

        // Elections are in progress!
        // Given an array of the numbers of votes given to each of the candidates so far, and an integer
        // k equal to the number of voters who haven't cast their vote yet, find the number of candidates who still have a chance to win the election.
        // The winner of the election must secure strictly more votes than any other candidate. If two or more candidates receive the same (maximum)
        // number of votes, assume there is no winner at all.
        public int ElectionsWinners(int[] votes, int k)
        {
            int max = votes.Max();
            int numOfMax = votes.Count(v => v == max);
            return votes.Aggregate(0, (acc, v) => acc + ((v == max && numOfMax == 1) || v + k > max ? 1 : 0));

        }

        // A media access control address (MAC address) is a unique identifier
        // assigned to network interfaces for communications on the physical network segment.
        // The standard (IEEE 802) format for printing MAC-48 addresses in human-friendly form is six groups of two hexadecimal digits (0 to 9 or A to F),
        // separated by hyphens (e.g. 01-23-45-67-89-AB).
        // Your task is to check by given string inputString whether it corresponds to MAC-48 address or not.
        public bool IsMAC48Address(string inputString)
        {
            char delimiter = '-';
            string[] substrings = inputString.Split(delimiter);

            if (substrings.Length != 6)
            {
                return false;
            }
            string pattern = "^([0-9A-Fa-f]{2}-){5}[0-9A-Fa-f]{2}$";
            return Regex.IsMatch(inputString, pattern);


        }







    }
}
