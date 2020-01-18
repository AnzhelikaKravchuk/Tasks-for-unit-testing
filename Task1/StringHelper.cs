using System;

namespace Task1
{
    /// <summary>
    /// Main class of the program for getting nubmer of vowels method.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Method for getting count of vowel in string.
        /// </summary>
        /// <param name="str">Source string.</param>
        /// <exception cref="ArgumentNullException">Throw when string is null.</exception>
        /// <exception cref="ArgumentException">Throw when string has no characters.</exception>
        /// <returns>Nubmer of vowels.</returns>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("str.Length = 0", nameof(str));
            }

            int count = 0;
            char[] mas = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char x in str)
            {
                foreach (char y in mas)
                {
                    if (x == y)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
