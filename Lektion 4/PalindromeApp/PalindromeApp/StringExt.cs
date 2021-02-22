using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    public static class StringExt
    {
        public static bool IsPalindrome(this string s, int i, bool palindrome)
        {
            if(i > s.Length / 2)
            {
                return palindrome;
            } else
            {
                Char[] temp = s.ToLower().ToCharArray();
                if(!isSameChar(temp[i], temp[temp.Length - i - 1])) {
                    palindrome = false;
                }
                return IsPalindrome(s, i + 1, palindrome);
            }
        }

        public static bool isSameChar(Char a, Char b)
        {
            return a == b ? true : false;
        }
    }
}
