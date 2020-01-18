using System;

namespace Task2
{
    /// <summary>
    /// This class contains GetGcd method.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// This method counts the greatest common divisor of two integers.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>This method returns the greatest common divisor.</returns>
        /// <exception cref="ArgumentException">Both numbers cannot be equal zero.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException($"Parameters {nameof(a)} and {nameof(b)} cannot be 0 at the same time.");
            }

            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return (a > 0) ? a : -a;
        }
    }
}