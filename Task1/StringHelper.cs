// <copyright file="StringHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task1
{
    using System;

    /// <summary >
    /// Сlass StringHelper.
    /// </summary >
    public static class StringHelper
    {
        /// <summary >
        /// Algorith of finding all vowels in a string.
        /// </summary >
        /// <param  name = " str " > Initial string. </param >
        /// <exception cref="ArgumentNullException">Throw when string is null.</exception>
        /// <exception cref="ArgumentException">Throw when string has no characters.</exception>
        /// <returns>Number of vowels in a string.  </returns>
        public static int GetVowelCount(string str)
        {
            int result = 0;
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("hthtr");
            }

            foreach (char symbol in str)
            {
                if (symbol == 'a')
                {
                    result++;
                }
                else if (symbol == 'e')
                {
                    result++;
                }
                else if (symbol == 'i')
                {
                    result++;
                }
                else if (symbol == 'o')
                {
                    result++;
                }
                else if (symbol == 'u')
                {
                    result++;
                }
            }

            return result;
            throw new NotImplementedException();
        }
    }
}
