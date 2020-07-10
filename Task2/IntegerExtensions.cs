using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException($"{nameof(a)} and {nameof(b)} cannot be 0 at the same time.");
            }

            if ((a == int.MinValue && b == int.MaxValue) || (b == int.MinValue && a == int.MaxValue))
            {
                return 1;
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (b == 0)
            {
                return a;
            }

            else
            {
                return GetGcd(b, a % b);
            }
        }
    }
}