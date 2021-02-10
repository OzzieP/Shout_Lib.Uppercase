using System;

namespace UpperString
{
    public static class StringLibrary
    {
        public static string StringToUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";

            }
            string upperString = str.ToUpper();
            return upperString;
        }
    }
}
