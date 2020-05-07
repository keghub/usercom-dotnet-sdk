using System.Text.RegularExpressions;

namespace UserCom
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string str)
        {
            return Regex.Replace(str, "[A-Z]","_$0").TrimStart('_').ToLower();
        }
    }
}