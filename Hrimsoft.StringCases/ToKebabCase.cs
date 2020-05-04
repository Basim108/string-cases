namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToKebabExtension
    {
        /// <summary>
        /// Convert a string to kebab-case.
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns kebab cased string like: "to-kebab-case"</returns>
        public static string ToKebabCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            var parts = source.SplitOnToParts();
            return string.Join("-", parts);
        }
    }
}