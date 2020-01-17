using System;
using System.Collections.Generic;

namespace Task1
{
    /// <summary>Provides methods for interacting with strings.</summary>
    public static class StringHelper
    {
        /// <summary>Gets a number of vowels in the given string.</summary>
        /// <param name="str">The string.</param>
        /// <returns>Returns number of vowels.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <me>str</me> is <me>null</me>.</exception>
        /// <exception cref="ArgumentException">Thrown when string is empty.</exception>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty.", nameof(str));
            }

            int vowelsCount = 0;
            var vowels = new List<char>
            {
                'a', 'e', 'i', 'o', 'u',
            };
            foreach (var letter in str)
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
