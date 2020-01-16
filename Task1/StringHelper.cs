using System;

namespace Task1
{
    /// <summary>
    /// Class to work with string.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Method to count vowels.
        /// </summary>
        /// <param name="str">Contains the string to search vowels.</param>
        /// <returns>Returns the count of vowels in str.</returns>
        /// <exception cref="ArgumentNullException">Thrown when str is null.</exception>
        /// <exception cref="ArgumentException">Thrown when str is empty string.</exception>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String length must be bigger than zero", nameof(str));
            }

            int ret = 0;
            string vowels = "aouei";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        ret++;
                    }
                }
            }

            return ret;
        }
    }
}
