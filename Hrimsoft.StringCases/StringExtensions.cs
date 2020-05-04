﻿﻿using System.Collections.Generic;

 namespace Hrimsoft.StringCases
{
    /// <summary>
    /// Extension methods for String type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Разделяет строку на части по разделителям или символам в верхнем регистре
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IList<string> SplitOnToParts(this string source)
        {
            var parts = new List<string>();
            var lexeme = new List<string>();

            for (var i = 0; i < source.Length; i++)
            {
                if (source[i].IsDelimiter() || source[i].IsUpperCase())
                {
                    if (lexeme.Count > 0)
                    {
                        parts.Add(string.Join("", lexeme));
                        lexeme.Clear();
                    }

                    if (!source[i].IsDelimiter())
                    {
                        lexeme.Add(source[i].ToString().ToLowerInvariant());
                    }
                }
                else
                {
                    lexeme.Add(source[i].ToString().ToLowerInvariant());
                }
            }

            if (lexeme.Count > 0)
                parts.Add(string.Join("", lexeme));

            return parts;
        }
    }
}