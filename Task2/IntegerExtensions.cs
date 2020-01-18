using System;

namespace Task2
{
    /// <summary>
    /// Class IntegerExtensions.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Algorithm for finding the GCD of two integers.
        /// </summary>
        /// <param name="a">Firrst int number.</param>
        /// <param name="b">Second int number.</param>
        /// <returns>GCD of two integers.</returns>
        public static int GetGcd(int a, int b)
        {
            if ((a == 0) && (b == 0))
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue && b == int.MaxValue)
            {
                return 1;
            }

            if (a == int.MaxValue && b == int.MinValue)
            {
                return 1;
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
            throw new NotImplementedException();
        }
    }
}