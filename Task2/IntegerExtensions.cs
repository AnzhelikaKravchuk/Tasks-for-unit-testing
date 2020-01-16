using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {  
            long first = a;
            long second = b;
            first = Math.Abs(first);
            second = Math.Abs(second);
            int GCM = 1;
            while (first != 0 & second != 0)
            {
                if (first > second)
                {
                    first %= second;
                    if (first == 0)
                    {
                        GCM = (int) second;
                        break;
                    }
                }
                else
                {
                    second %= first;
                    if (second == 0)
                    {
                        GCM = (int)first;
                        break;
                    }
                }
            }
            if(first==0||second==0)
            {
                GCM = (int)(first + second);
            }
            if(first == 0 && second == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }
            return GCM;
        }
    }
}