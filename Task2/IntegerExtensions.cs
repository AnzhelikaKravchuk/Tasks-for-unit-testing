using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {
            if (a == 0 & b == 0)
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

            for (; ;)
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

            throw new NotImplementedException();
        }
    }
}