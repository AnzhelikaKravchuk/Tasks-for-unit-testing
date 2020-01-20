using System;

namespace Task1
{
    /// <summary>
    /// Class StringHelper.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Return the number (count) of vowels in the given string.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>number of vowels in the given string.</returns>
        /// <exception cref="System.ArgumentException">Thrown when string is empty.</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when string is null.</exception>
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

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
