using System;

namespace Task2
{
    /// <summary>
    /// Class to work with number theory.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Method to get GCD of two numbers.
        /// </summary>
        /// <param name="a">First integer number to find GCD.</param>
        /// <param name="b">Second integer number to find GCD.</param>
        /// <returns>Returns the GCD of a and b.</returns>
        /// <exception cref="ArgumentException">Thrown when both parameters equal to zero.</exception>
        public static int GetGcd(int a, int b)
        {
            if (Math.Max(a, b) == 0 && Math.Min(a, b) == int.MinValue)
            {
                throw new OverflowException("OverFlow_NegateTwosCompNum");
            }

            long ua = Math.Abs((long)a);
            long ub = Math.Abs((long)b);
            if (ua == 0 && ub == 0)
            {
                throw new ArgumentException("Parameters must not be equal to zero");
            }

            while (ua != ub)
            {
                if (ua > ub)
                {
                    ua -= ub;
                }
                else
                {
                    ub -= ua;
                }

                if (ua == ub)
                {
                    return (int)ua;
                }

                if (ua == 0)
                {
                    return (int)ub;
                }

                if (ub == 0)
                {
                    return (int)ua;
                }
            }

            return a;
        }
    }
}