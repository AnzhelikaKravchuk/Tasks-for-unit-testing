using System;

namespace Task1
{
    /// <summary>
    /// This class includes GEtVowelCount method.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Counts vowels in a string.
        /// </summary>
        /// <param name="str">String to count vowels from.</param>
        /// <returns>Number of vowels in a string.</returns>
        /// <exception cref="ArgumentNullException">Argument cannot be null.</exception>
        /// <exception cref="ArgumentException">Argument cannot be an empty string.</exception>
        public static int GetVowelCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(str, "String you pass cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("Argument cannot be an empty string.", str);
            }

            int vowel_counter = 0;

            foreach (char i in str)
            {
                if (i == 'a' || i == 'e' || i == 'i'
                    || i == 'o' || i == 'u')
                {
                    vowel_counter++;
                }
            }

            return vowel_counter;
        }
    }
}
