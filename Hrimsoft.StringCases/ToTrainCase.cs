using System.Text;

namespace Hrimsoft.StringCases
{
    /// <summary> </summary>
    public static class ToTrainCaseExtension
    {
        /// <summary>
        /// Convert a string to Train-Cased-One.
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>Returns train cased string like: "To-Train-Case"</returns>
        public static string ToTrainCase(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) 
                return "";
            
            var parts = source.SplitOnToParts();
            var result = new StringBuilder(source.Length + parts.Count);
            for (var i = 0; i < parts.Count; i++)
            {
                var name = parts[i];
                result.Append($"{char.ToUpperInvariant(name[0])}{name.Substring(1)}");
                if (i < parts.Count - 1)
                    result.Append('-');
            }
            return result.ToString();
        }
    }
}