using System;
using System.Text.RegularExpressions;

namespace Task1
{
    /// <summary>
    /// This class finds amount of vowels in strings.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// This method counts amount fo vowels in the string.
        /// </summary>
        /// <param name="str">String, where you want to count vowels.</param>
        /// <returns>Amount of vowels in string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the string is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the string is empty.</exception>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null");
            }
            else if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty", nameof(str));
            }

            Regex regex = new Regex("[a|e|i|o|u]{1}");
            MatchCollection matchCollection = regex.Matches(str);
            return matchCollection.Count;
        }
    }
}
