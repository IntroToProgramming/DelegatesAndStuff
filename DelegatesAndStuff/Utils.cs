using System;

namespace DelegatesAndStuff.Utilities
{
    public static class Utils
    {
        public static string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public static bool IsEven(this int n) => n % 2 == 0;

        public static string MakeTag(this string tag, string content)
        {
            return $"<{tag}>{content}</{tag}>";
        }
        public static DateTime DaysFromToday(this int  days)
        {
            return DateTime.Now.AddDays(days);
        }
    }
}
