namespace Task1
{
    using System;

    /// <summary>
    /// An application entry point.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Function that gets the number of vowels in the string.
        /// </summary>
        /// <param name="str">An input string.</param>
        /// <exception cref="ArgumentException">Throws when the string is empty.</exception>
        /// <exception cref="ArgumentNullException">Throws when the string is null.</exception>
        /// <returns>The return is the number of vowels in the string.</returns>
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

            int counter = 0;
            foreach (char character in str)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}