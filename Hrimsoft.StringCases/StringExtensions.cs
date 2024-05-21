﻿using System.Collections.Generic;

 namespace Hrimsoft.StringCases
{
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

            for (var i = 0; i < source.Length; i++) {
                var isUpperDelimiter = i > 0 && char.IsUpper(source[i]) && !char.IsUpper(source[i - 1]);
                var isLowerDelimiter = i > 1 && char.IsLower(source[i]) && char.IsUpper(source[i - 1]) && char.IsUpper(source[i - 2])
                                        || i > 0 && char.IsLower(source[i]) && char.IsDigit(source[i - 1]);
                
                if (source[i].IsDelimiter() || isUpperDelimiter || isLowerDelimiter || char.IsDigit(source[i]))
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