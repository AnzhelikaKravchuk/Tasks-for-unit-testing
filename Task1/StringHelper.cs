using System;

namespace Task1
{
    public static class StringHelper
    {
        public const string VOVELS = "aeiou";
        public static int GetVowelCount(string str)
        {
            Validate(str);

            int counter = 0;
            foreach (char ch in str)
            {
                foreach (char temp in VOVELS)
                {
                    if (ch == temp)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        private static void Validate(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException($"{nameof(str)} cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException($"{nameof(str)} cannot be empty.");
            }
        }
    }
}
