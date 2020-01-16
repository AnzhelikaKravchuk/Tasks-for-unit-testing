namespace Task2
{
    using System;

    /// <summary>
    /// An application entry point.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Function that gets the gcd of two numbers.
        /// </summary>
        /// <param name="a">The first input number.</param>
        /// <param name="b">The second input number.</param>
        /// <exception cref="ArgumentException">Throws when the values are zero.</exception>
        /// <returns>The return is the gcd of two values.</returns>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two values cannot be zero at the same time.");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            return GetGcd(b, a % b);
        }
    }
}