namespace Hrimsoft.StringCases
{
    /// <summary>
    /// Extensions for char primitives
    /// </summary>
    internal static class CharExtensions
    {
        /// <summary>
        /// Tests a symbol for being upper case
        /// </summary>
        /// <param name="symbol">tested symbol</param>
        /// <returns></returns>
        public static bool IsUpperCase(this char symbol)
        {
            var result = symbol >= 'A' && symbol <= 'Z';
            return result;
        }

        /// <summary>
        /// Tests a symbol for being a delimiter
        /// </summary>
        /// <param name="symbol">tested symbol</param>
        /// <returns></returns>
        public static bool IsDelimiter(this char symbol)
        {
            var result = symbol == ' ' || symbol == '_' || symbol == '.' || symbol == '-';
            return result;
        }
    }
}