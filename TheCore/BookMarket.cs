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





    }
}
