using System;

namespace Task2
{
    /// <summary>
    /// Class for getting GCD method.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Method for getting GCD of two numbers.
        /// </summary>
        /// <param name="a">the first nubmer.</param>
        /// <param name="b">the second number.</param>
        /// <exception cref="ArgumentException">Throw when both numbers are zero,
        /// when arguments are (0 and int.MinValue) or (int.MinValue and 0).</exception>
        /// <returns>GCD.</returns>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == int.MinValue)
            {
                throw new ArgumentException("Arguments cannot be 0 and int.MinValue");
            }

            if (a == int.MinValue && b == 0)
            {
                throw new ArgumentException("Arguments cannot be int.MinValue and 0");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("a = 0 and b = 0");
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            while (true)
            {
                if ((a %= b) == 0)
                {
                    return Math.Abs(b);
                }
                else if
                    ((b %= a) == 0)
                {
                    return Math.Abs(a);
                }
            }
        }
    }
}