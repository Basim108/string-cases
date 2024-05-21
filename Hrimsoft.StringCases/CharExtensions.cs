namespace Hrimsoft.StringCases
{
    internal static class CharExtensions
    {
        /// <summary>
        /// Tests a symbol for being a delimiter: space, _ , . , -
        /// </summary>
        /// <param name="symbol">tested symbol</param>
        public static bool IsDelimiter(this char symbol)
        {
            var result = symbol == ' ' || symbol == '_' || symbol == '.' || symbol == '-';
            return result;
        }
    }
}