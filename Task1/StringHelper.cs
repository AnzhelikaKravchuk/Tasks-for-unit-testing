using System;

namespace Task1
{
    /// <summary>
    /// The StringHelper class.
    /// Contains all methods for examining string.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Counts how many vowels are there in the input string.
        /// </summary>
        /// <param name="str">Input string for examining.</param>
        /// <exception cref="ArgumentNullException()">Thrown when input string is null.</exception>
        /// <exception cref="ArgumentException()">Thrown when input string is empty.</exception>
        /// <returns>
        /// Amount of vowels in the input string.
        /// </returns>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty.");
            }

            int count = 0;

            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
