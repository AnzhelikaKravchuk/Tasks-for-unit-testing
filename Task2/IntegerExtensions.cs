// <copyright file="IntegerExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task2
{
    using System;

    /// <summary >
    /// Сlass StringHelper.
    /// </summary >
    public static class IntegerExtensions
    {
        /// <summary >
        /// Algorith of finding the GCD of two integer.
        /// </summary >
        /// <param  name = " a " > First int number. </param >
        /// <param  name = " b " > Second int number. </param >
        /// <exception cref="ArgumentException">Two numbers are equal 0 at the same time.</exception>
        /// <returns>GCD of two integer.  </returns>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return GetGcd(b, a % b);
            }
        }
    }
}