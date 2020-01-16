using System;

namespace Task2
{
    /// <summary>
    /// The main class which have been testing.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Method for finding the greatest common divisor of two integers.
        /// </summary>
        /// <param name="a"> Number 1. </param>
        /// <param name="b"> Number 2. </param>
        /// <returns> Greatest common divisor. </returns>
        /// <exception cref="ArgumentException()"> Two numbers cannot be 0 at the same time. </exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            return b == 0 ? Math.Abs(a) : GetGcd(b, a % b);
        }
    }
}