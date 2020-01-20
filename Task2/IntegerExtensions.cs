using System;

namespace Task2
{
    /// <summary>
    /// The IntegerExtensions class.
    /// Contains method for finding the great common divisor.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Finds the great common divisor of two integer numbers in range (int.MinValue;int.MaxValue].
        /// </summary>
        /// <param name="a">First integer number to find the great common divisor.</param>
        /// <param name="b">Second integer number to find the great common divisor.</param>
        /// <exception cref="ArgumentException()">Thrown when both numbers are 0 at the same time.</exception>
        /// <returns>
        /// The great common divisor of two integer numbers.
        /// </returns>
        public static int GetGcd(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentException("int.MinValue is not in an allowable range (int.MinValue;int.MaxValue]");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return a + b;
        }
    }
}