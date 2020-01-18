using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {
            if ((a == 0) && (b == 0)) throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            if (a == int.MinValue && b == int.MaxValue) return 1;
            if (a == int.MaxValue && b == int.MinValue) return 1;
            if (a < 0) a = a * (-1);
            if (b < 0) b = b * (-1);
            if (a == 0) return b;
            if (b == 0) return a;
           

            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
            throw new NotImplementedException();
        }
    }
}