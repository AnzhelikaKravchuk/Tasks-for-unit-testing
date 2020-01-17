using System;

namespace Task1
{
    /// <summary>
    /// This class is for finding letters.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// This method is for finding correct letters.
        /// </summary>
        /// <param name="str">
        /// It is a letter.
        /// </param>
        /// <returns>
        /// It is a number of letters.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// String cannot be null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// String cannot be empty.
        /// </exception>
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

            int sum = 0;
            foreach (char letter in str)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        sum++;
                    }
                }

            return sum;
        }
    }
}