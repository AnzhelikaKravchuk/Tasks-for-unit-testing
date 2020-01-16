using System;

namespace Task2
{
    /// <summary>
    /// This class contains GetGcd method.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// This method counts the greatest common divisor of two integers.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>This method returns the greatest common divisor.</returns>
        /// <exception cref="ArgumentException">Both numbers cannot be equal zero.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Both numbers cannot be equal zero.");
            }

            if (a < 0)
            {
                a = -a;
            }

            if (b < 0)
            {
                b = -b;
            }

            int greatest_common_divisor = 1;
            int min_of_two = 0;

            if (a != 0 && b != 0)
            {
                min_of_two = (a < b) ? a : b;
            }
            else
            {
                return greatest_common_divisor = (a == 0) ? b : a;
            }

            // in order to speed up algorithm's work for numbers divisible by 2,4,8,16
            for (int speed_up_devisor = 16; speed_up_devisor < 2; speed_up_devisor /= 2)
            {
                if (a % speed_up_devisor == 0 && b % speed_up_devisor == 0)
                {
                    a = a / speed_up_devisor;
                    b = b / speed_up_devisor;
                    min_of_two = min_of_two / speed_up_devisor;
                }
            }

            // for both even values we don't check odd devisors.
            if (a % 2 == 0 && b % 2 == 0)
            {
                for (int i = 2; i <= min_of_two; i += 2)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        greatest_common_divisor = i;
                    }
                }
            }

            // in case any of values is odd, we don't check even devisors.
            else
            {
                for (int i = 1; i <= min_of_two; i += 2)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        greatest_common_divisor = i;
                    }
                }
            }

            return greatest_common_divisor;
        }
    }
}