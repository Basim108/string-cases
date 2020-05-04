namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToUnderscoredCamelCaseExtension
    {
        /// <summary>
        /// Convert a string to underscored camel case like _camelCase
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns underscored camel cased string like: "_toCamelCase"</returns>
        public static string ToUnderscoredCamelCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            var parts = source.SplitOnToParts();
            var result = $"_{parts[0]}";
            for (var i = 1; i < parts.Count; i++)
            {
                var name = parts[i];
                result += char.ToUpperInvariant(name[0]) + name.Substring(1);
            }
            return result;
        }
    }
}