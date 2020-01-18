using System;

namespace Task1
{
    public static class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null) throw new ArgumentNullException("String cannot be null.");
            if (str.Equals(string.Empty)) throw new ArgumentException("String cannot be empty.");
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if ((str[i] == 'a') || (str[i] == 'e') || (str[i] == 'i') || (str[i] == 'o') || (str[i] == 'u'))
                {
                    count++;
                }
            }

            return count;
            throw new NotImplementedException();
        }
    }
}
