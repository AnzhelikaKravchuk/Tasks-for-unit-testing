using System;

namespace Task2
{
    /// <summary>Provides methods for integer extensions.</summary>
    public static class IntegerExtensions
    {
        /// <summary>Gets the GCD of two integer numbers.</summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns GCD of two numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when two numbers are zero.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            uint absA = (uint)Math.Abs((long)a);
            uint absB = (uint)Math.Abs((long)b);
            static int EuclideanAlgorithm(uint absA, uint absB)
            {
                var remainder = absA - absB;
                while (remainder != 0)
                {
                    var tmp = absB;
                    absB = absA % absB;
                    absA = tmp;
                    remainder = absB;
                }

                return (int)absA;
            }

            return absA >= absB ? EuclideanAlgorithm(absA, absB) : EuclideanAlgorithm(absB, absA);
        }
    }
}
