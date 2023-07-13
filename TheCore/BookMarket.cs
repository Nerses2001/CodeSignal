using System;
using System.Linq;

namespace CodeSignal.TheCore
{
    internal class BookMarket
    {
        // Given a string, enclose it in round brackets.
        public string EncloseInBrackets(string inputString) => $"({inputString})";

        // Proper nouns always begin with a capital letter, followed by small letters.
        // Correct a given proper noun so that it fits this statement.
        public string ProperNounCorrection(string noun) => $"{char.ToUpper(noun[0])}{noun.Substring(1).ToLower()}";

        // Determine whether the given string can be obtained by one concatenation of some string to itself.
        public bool IsTandemRepeat(string inputString) => inputString.Length % 2 == 0 && Enumerable.Range(0, inputString.Length / 2).All(i => inputString[i] == inputString[i + inputString.Length / 2]);
        /* {
            if(inputString.Length % 2 != 0) return false;

            for(int i = 0 ; i < inputString.Length / 2; ++i)
            {
                if(inputString[i] != inputString[i + inputString.Length / 2])
                {
                    return false;
                }
            } 
            return true;

        }
        */

        // Given a string, check if it can become a palindrome through a case change of some (possibly, none) letters.
        public bool IsCaseInsensitivePalindrome(string inputString) => inputString.ToLower().ToCharArray().Reverse().SequenceEqual(inputString.ToLower().ToCharArray());

        // An email address such as "John.Smith@example.com" is made up of a local part ("John.Smith"), an "@" symbol, then a domain part ("example.com").
        // The domain name part of an email address may only consist of letters, digits, hyphens and dots.
        // The local part, however, also allows a lot of different special characters.
        // Here you can look at several examples of correct and incorrect email addresses.
        // Given a valid email address, find its domain part.
        public string FindEmailDomain(string address) => address.Split('@').Last();

        // You are implementing your own HTML editor. To make it more comfortable for developers you would like to add an auto-completion feature to it.
        // Given the starting HTML tag, find the appropriate end tag which your editor should propose.
        // If you are not familiar with HTML, consult with this note.
        public string HTMLEndTagByStartTag(string startTag) => startTag.Split(' ').Length > 1 ? startTag.Split(' ')[0].Insert(1, "/") + ">" : startTag.Insert(1, "/");


        // A media access control address (MAC address) is a unique identifier assigned to network interfaces for communications on the physical network segment.
        // The standard (IEEE 802) format for printing MAC-48 addresses in human-friendly form is six groups of two hexadecimal digits (0 to 9 or A to F), separated by hyphens (e.g. 01-23-45-67-89-AB).
        // Your task is to check by given string inputString whether it corresponds to MAC-48 address or not.
        public bool IsMAC48Address(string inputString) => inputString.Split('-').Length == 6 && inputString.Split('-').All(a => System.Text.RegularExpressions.Regex.IsMatch(a, "^[A-F0-9]{2}$"));

        // Some file managers sort filenames taking into account case of the letters, others compare strings as if all of the letters are of the same case. That may lead to different ways of filename ordering.
        // Call two filenames an unstable pair if their ordering depends on the case.
        // To compare two filenames a and b, find the first position i at which a[i] ≠ b[i]. If a[i] < b[i], then a < b. Otherwise a > b.
        // If such position doesn't exist, the shorter string goes first.
        // Given two filenames, check whether they form an unstable pair.
        public bool IsUnstablePair(string filename1, string filename2) => (String.Compare(filename1, filename2, StringComparison.Ordinal) < 0 != String.Compare(filename1.ToLower(), filename2.ToLower(), StringComparison.Ordinal) < 0);







    }
}
