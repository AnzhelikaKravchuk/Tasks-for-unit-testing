using System;

namespace Task2
{
    /// <summary>
    /// The main class of Task2 about searching GCD of two numbers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Method The method that searches for the greatest common divisor of two integers.
        /// </summary>
        /// <param name="a"> Number 1. </param>
        /// <param name="b"> Number 2. </param>
        /// <returns> Greatest common divisor. </returns>
        /// <exception cref="ArgumentException()"> Two numbers cannot be 0 at the same time. </exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("${nameof(a)} and {nameof(b)} cannot be 0 at the same time.");
            }

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return Math.Abs(a);
        }
    }
}