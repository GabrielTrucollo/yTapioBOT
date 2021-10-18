﻿namespace yTapioBOT.Library
{
    using System;
    using System.Linq;

    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string to PascalCase
        /// </summary>
        /// <param name="str">String to convert</param>
        public static string ToPascalCase(this string str)
        {
            // Replace all non-letter and non-digits with an underscore and lowercase the rest.
            string sample = string.Join("", str?.Select(c => char.IsLetterOrDigit(c) ? c.ToString().ToLower() : "_").ToArray());

            // Split the resulting string by underscore
            // Select first character, uppercase it and concatenate with the rest of the string
            var arr = sample?
                .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => $"{s.Substring(0, 1).ToUpper()}{s[1..]}");

            // Join the resulting collection
            sample = string.Join("", arr);

            // Retorno
            return sample;
        }
    }
}