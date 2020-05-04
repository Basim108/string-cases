namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToCamelCaseExtension
    {
        /// <summary>
        /// Convert a string to camelCase
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns camel cased string like: "toCamelCase"</returns>
        public static string ToCamelCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            var parts = source.SplitOnToParts();
            var result = parts[0];
            for (var i = 1; i < parts.Count; i++)
            {
                var name = parts[i];
                result += $"{char.ToUpperInvariant(name[0])}{name.Substring(1)}";
            }
            return result;
        }
    }
}