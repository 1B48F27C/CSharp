using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class CharExtensions
    {
        public static bool IsVowel(this char ch)
        {
            var isVowel = false;
            if (ch.Equals('a') || ch.Equals('e') || ch.Equals('o') || ch.Equals('u') || ch.Equals('i')) isVowel = true;
            return isVowel;
        }
    }
}
