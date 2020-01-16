using System;

namespace Task1
{
    /// <summary>
    /// The main class which have been testing.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// This method return the number (count) of vowels in the given string.
        /// </summary>
        /// <param name="str"> The input string will only consist of lower case letters and/or spaces. </param>
        /// <returns> Number (count) of vowels. </returns>
        /// <exception cref="ArgumentNullException()"> The input string cannot be null. </exception>
        /// <exception cref="ArgumentException()"> The input string cannot be empty. </exception>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("Send an appropriate phrase, please.", new Exception());
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("Send an appropriate phrase, please.");
            }

            int result = 0;
            string vowels = "aeiou";

            foreach (char letter in str)
            {
                if (vowels.Contains(letter, StringComparison.Ordinal))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
