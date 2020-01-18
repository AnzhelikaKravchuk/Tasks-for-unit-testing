using System;

namespace Task2
{
    /// <summary>
    /// This class helps to find the greatest common divisor of two integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// This method finds the greatest common divisor of two integers using Euclid's algorithm.
        /// </summary>
        /// <param name="a">First integer parameter to find the greatest common divisor.</param>
        /// <param name="b">Second integer parameter to find the greatest common divisor.</param>
        /// <returns>The greatest common divisor.</returns>
        /// <exception cref="ArgumentException">Thrown when both parameters are 0.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", $"{nameof(a)}, {nameof(b)}");
            }
            else if (a == 0)
            {
                return Math.Abs(b);
            }
            else if (b == 0)
            {
                return Math.Abs(a);
            }

            int switcher;
            while (a != 0)
            {
                switcher = a;
                a = b % a;
                b = switcher;
            }

            return Math.Abs(b);
        }
    }
}