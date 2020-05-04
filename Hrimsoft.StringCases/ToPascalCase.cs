namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToPascalCaseExtension
    {
        /// <summary>
        /// Convert a string to pascal cased one/
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns a string like: "ThisIsAPascalCase"</returns>
        public static string ToPascalCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            var result = "";
            var parts = source.SplitOnToParts();
            foreach (var name in parts)
                result += char.ToUpperInvariant(name[0]) + name.Substring(1);
            return result;
        }
    }
}