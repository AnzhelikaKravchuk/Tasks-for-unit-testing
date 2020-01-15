using System;

namespace Task1
{
    public static class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("String cannot be null.");
            }
            else if(str=="")
            {
                throw new ArgumentException("String cannot be empty.");
            }
            int Sum = 0;            
            char[] letters = str.ToCharArray();
            foreach (char letter in letters)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    Sum++;
                }                
            }            
            return Sum;           
        }
    }
}
