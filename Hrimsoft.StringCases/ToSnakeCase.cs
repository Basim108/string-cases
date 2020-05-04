namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToSnakeCaseExtension
    {
        /// <summary>
        /// Convert a string to snake cased one.
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns snake cased string like: "this_is_a_snake_case"</returns>
        public static string ToSnakeCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            var parts = source.SplitOnToParts();
            return string.Join("_", parts);
        }
    }
}