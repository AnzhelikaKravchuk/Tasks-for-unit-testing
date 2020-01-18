using System;

namespace Task1
{
    public static class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("str.Length = 0", nameof(str));
            }

            int count = 0;
            char[] mas = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char x in str)
            {
                foreach (char y in mas)
                {
                    if (x == y)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
            throw new NotImplementedException();
        }
    }
}
